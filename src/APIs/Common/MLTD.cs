namespace MLTDABD.APIs
{
    internal class MLTD
    {
        public static string AssetUrl(string host, string unityVersion, UMPF platform, int resourceVersion, string assetName)
        {
            var platformName = GetPlatformName(platform);
            var assetPath = $"/production/{unityVersion}/{platformName}/{assetName}";
            var assetUrl = $"https://{host}/{resourceVersion}{assetPath}";
            return assetUrl;
        }

        private static string GetPlatformName(UMPF platform)
        {
            switch (platform)
            {
                case UMPF.Android:
                    return "Android";
                case UMPF.iOS:
                    return "iOS";
                default:
                    throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
            }
        }

        internal const string UnityVersion_Default = "2018";

        internal const string UnityVersion_Legacy = "2017.3";

        internal const string Host_v1 = "d2sf4w9bkv485c.cloudfront.net";

        internal const string Host_v2 = "td-assets.bn765.com";

    }
}
