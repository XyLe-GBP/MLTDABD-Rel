using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MLTDABD.APIs.Matsurihi.MeCommon
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    internal sealed class LVersion
    {
        [JsonConstructor]
        public LVersion()
        {
        }

        [JsonProperty]
        public Version? App { get; set; }

        [JsonProperty]
        public RVersion? Res { get; set; }
    }
}
