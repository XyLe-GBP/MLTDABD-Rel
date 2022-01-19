namespace MLTDABD.APIs.Matsurihi
{
    internal class MeApi
    {
        public static string LatestVersion()
        {
            const string url = BaseAddress + "/version/latest";
            return url;
        }

        public static string AssetVersions()
        {
            const string url = BaseAddress + "/version/assets";
            return url;
        }

        public static string AssetVersion(int version)
        {
            const string urlTemplate = BaseAddress + "/version/assets/{0}";
            return string.Format(urlTemplate, version.ToString());
        }

        private const string BaseAddress = "https://api.matsurihi.me/mltd/v1";

    }
}
