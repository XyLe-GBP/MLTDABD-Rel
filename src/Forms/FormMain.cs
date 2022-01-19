using System.Diagnostics;
using System.Reflection;
using MLTD;
using MLTD.Assets;
using MLTDABD.APIs;
using MLTDABD.Forms;

namespace MLTDABD_Rel
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FileVersionInfo ver = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
            if (ver.FileVersion != null)
            {
                Text = "MLTD Asset Bundle Downloader 'MLTDABD' Rel ( build: " + ver.FileVersion.ToString() + "-Beta )";
            }

        }

        private void MnuFileOpenLocal_Click(object sender, EventArgs e)
        {
            ofd.CheckFileExists = true;
            ofd.DereferenceLinks = true;
            ofd.Filter = "Asset Database (*.data)|*.data";
            ofd.Multiselect = false;
            ofd.ReadOnlyChecked = false;
            ofd.ShowReadOnly = false;
            ofd.SupportMultiDottedExtensions = true;
            ofd.ValidateNames = true;

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                var filePath = ofd.FileName;
                var data = File.ReadAllBytes(filePath);

                var b = AssetInfoList.TryParse(data, out var assetInfoList);

                if (!b)
                {
                    var message = $"'{filePath}' is not a valid asset database file.";
                    MessageBox.Show(message, ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Debug.Assert(assetInfoList != null);

                var opening = ManifestOpening.Local(filePath);

                var form = new FormAsset(assetInfoList, opening, null!)
                {
                    MdiParent = this
                };

                form.Show();
            }
            else
            {
                return;
            }
        }

        private async void MnuFileOpenRemote_Click(object sender, EventArgs e)
        {
            var (r, config) = FormAssetDownload.ShowModal(this);

            if (r == DialogResult.Cancel)
            {
                return;
            }

            Debug.Assert(config != null);

            byte[] assetInfoListData;

            try
            {
                assetInfoListData = await AssetDownloader.DownloadData(config.ResourceVersion, config.ManifestAssetName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var b = AssetInfoList.TryParse(assetInfoListData, out var assetInfoList);

            if (!b)
            {
                const string message = "Received data is not a valid asset database file.";
                MessageBox.Show(message, ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Debug.Assert(assetInfoList != null);

            var opening = ManifestOpening.Remote(config.ResourceVersion, config.IsLatest);

            var form = new FormAsset(assetInfoList, opening, config)
            {
                MdiParent = this
            };

            form.Show();
        }

        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            using var f = new FormAbout();
            f.ShowDialog(this);
        }

        private void MnuToolsDiff_Click(object sender, EventArgs e)
        {
            var children = MdiChildren;

            if (children.Length < 2)
            {
                return;
            }

            var manifestForms = new FormAsset[children.Length];

            for (var i = 0; i < manifestForms.Length; i += 1)
            {
                var form = children[i] as FormAsset;

                Debug.Assert(form != null);

                manifestForms[i] = form;
            }

            using var f = new FormDiff(manifestForms);
            f.ShowDialog(this);
        }

        private void MnuToolsIV_Click(object sender, EventArgs e)
        {
            var formIV = new FormIV
            {
                MdiParent = this,
            };
            
            formIV.Show();
        }

        private async void MnuDLManifest_Click(object sender, EventArgs e)
        {
            var (r, config) = FormAssetDownload.ShowModal(this);

            if (r == DialogResult.Cancel)
            {
                return;
            }

            Debug.Assert(config != null);

            byte[] assetInfoListData;

            try
            {
                assetInfoListData = await AssetDownloader.DownloadData(config.ResourceVersion, config.ManifestAssetName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new()
            {
                CheckFileExists = true,
                FileName = config.ResourceVersion.ToString(),
                Filter = @"Asset Database (*.data)|*.data",
                OverwritePrompt = true,
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                await File.WriteAllBytesAsync(sfd.FileName, assetInfoListData);
                if (File.Exists(sfd.FileName))
                {
                    MessageBox.Show("Download is complete.", ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start("EXPLORER.EXE", @"/select,""" + sfd.FileName + @"""");
                }
                else
                {
                    MessageBox.Show("Download failed.", ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuToolsAS_Click(object sender, EventArgs e)
        {
            var formAS = new AssetStudioGUI.AssetStudioGUIForm
            {
                MdiParent = this,
            };

            formAS.Show();
        }
    }
}