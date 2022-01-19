namespace MLTDABD.APIs
{
    internal class AssetDownloader
    {
        public static Task<byte[]> DownloadData(int resourceVersion, string assetName)
        {
            return DownloadData(resourceVersion, assetName, MLTD.UnityVersion_Default);
        }

        public static async Task<byte[]> DownloadData(int resourceVersion, string assetName, string unityVersion)
        {
            var url = MLTD.AssetUrl(MLTD.Host_v2, unityVersion, UMPF.Android, resourceVersion, assetName);
            var data = await Common.HttpClient.GetByteArrayAsync(url);

            return data;
        }

        public static Task DownloadToFile(int resourceVersion, string assetName, string destinationPath)
        {
            return DownloadToFile(resourceVersion, assetName, destinationPath, MLTD.UnityVersion_Default);
        }

        public static async Task DownloadToFile(int resourceVersion, string assetName, string destinationPath, string unityVersion)
        {
            var data = await DownloadData(resourceVersion, assetName, unityVersion);

            var tmpFileName = Path.GetTempFileName();
            File.WriteAllBytes(tmpFileName, data);

            {
                var fileInfo = new FileInfo(destinationPath);
                var dir = fileInfo.DirectoryName;

                if (dir != null)
                {
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                }
            }

            File.Copy(tmpFileName, destinationPath, true);

            File.Delete(tmpFileName);
        }
    }
}
