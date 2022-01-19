using MLTDABD.APIs.Matsurihi.MeCommon;
using Newtonsoft.Json;

namespace MLTDABD.APIs.Matsurihi
{
    internal sealed class Me
    {
        static Me()
        {
            Serializer = new JsonSerializer();
        }

        public static async Task<LVersion> GetLatestVersion()
        {
            var url = MeApi.LatestVersion();
            var text = await Common.HttpClient.GetStringAsync(url);

            var result = DeserializeString<LVersion>(text);

            return result;
        }

        public static async Task<RVersion[]> GetAssetVersions()
        {
            var url = MeApi.AssetVersions();
            var text = await Common.HttpClient.GetStringAsync(url);

            var result = DeserializeString<RVersion[]>(text);

            return result;
        }

        public static async Task<RVersion> GetAssetVersion(int version)
        {
            var url = MeApi.AssetVersion(version);
            var text = await Common.HttpClient.GetStringAsync(url);

            var result = DeserializeString<RVersion>(text);

            return result;
        }

        private static T DeserializeString<T>(string s)
        {
            T? result;

            using (var stringReader = new StringReader(s))
            {
                using var jsonReader = new JsonTextReader(stringReader);
                result = Serializer.Deserialize<T>(jsonReader);
            }

            if (result != null)
            {
                return result;
            }
            else
            {
                return result!;
            }
        }

        private static readonly JsonSerializer Serializer;

    }
}
