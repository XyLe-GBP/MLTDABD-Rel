﻿using JetBrains.Annotations;
using MLTD;
using MLTDABD.APIs;

namespace MLTDABD.Forms
{
    partial class FormDownload
    {

        private sealed class WorkerThread
        {

            public WorkerThread([NotNull] FormDownload form, [NotNull] DownloadConfig downloadConfig, [NotNull] string saveDir)
            {
                _form = form;
                _downloadConfig = downloadConfig;
                _saveDir = saveDir;

                _thread = new Thread(DoWork)
                {
                    Name = "Asset Download Worker",
                    IsBackground = true
                };
            }

            public void Start()
            {
                if (_thread.IsAlive)
                {
                    return;
                }

                _shouldStop = false;

                _thread.Start();
            }

            public void Abort()
            {
                if (!_thread.IsAlive)
                {
                    return;
                }

                _shouldStop = true;

                _thread.Join();

                _form.OnAllDownloadsComplete(false);
            }

            private async void DoWork()
            {
                var items = _form._items;
                var jobCount = items.Length;
                var downloaded = _form._downloaded;

                for (var i = 0; i < jobCount; i += 1)
                {
                    if (downloaded[i])
                    {
                        continue;
                    }

                    if (_shouldStop)
                    {
                        _form.OnAllDownloadsComplete(false);
                        return;
                    }

                    var localName = items[i].LocalName;
                    var remoteName = items[i].RemoteName;
                    var dstPath = Path.Combine(_saveDir, localName);

                    try
                    {
                        await AssetDownloader.DownloadToFile(_downloadConfig.ResourceVersion, remoteName, dstPath, _downloadConfig.UnityVersion);
                    }
                    catch (HttpRequestException ex)
                    {
                        var message = $"Failed to download {localName}. Please check download configuration (probably a res version mismatch), or Internet connection.";
                        AlertInMainThread(new ApplicationException(message, ex));
                        return;
                    }
                    catch (Exception ex)
                    {
                        AlertInMainThread(ex);
                        return;
                    }

                    if (_shouldStop)
                    {
                        _form.OnAllDownloadsComplete(false);
                        return;
                    }

                    downloaded[i] = true;

                    _form.ProgressFile(i, jobCount, localName);
                }

                _form.OnAllDownloadsComplete(true);
            }

            private void AlertInMainThread([NotNull] Exception ex)
            {
                _form.Invoke(new Action<Exception>(e => {
                    MessageBox.Show(e.ToString(), ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }), ex);
            }

            [NotNull]
            private readonly Thread _thread;

            private bool _shouldStop;

            [NotNull]
            private readonly FormDownload _form;

            [NotNull]
            private readonly DownloadConfig _downloadConfig;

            [NotNull]
            private readonly string _saveDir;

        }

    }
}
