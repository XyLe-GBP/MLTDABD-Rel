using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MLTDABD.APIs.Matsurihi.MeCommon
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    internal sealed class RVersion
    {
        [JsonConstructor]
        public RVersion()
        {
        }

        [JsonProperty]
        public int? Version { get; set; }

        [JsonProperty]
        public string? UpdateTime { get; set; }

        [JsonProperty]
        public string? IndexName { get; set; }
    }
}
