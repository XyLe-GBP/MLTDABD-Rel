using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace MLTDABD.APIs.Matsurihi.MeCommon
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    internal class Version
    {
        [JsonConstructor]
        public Version()
        {
        }

        [JsonProperty]
        public string? ToolVersion { get; set; }

        // Format: 2020-05-10T12:00:00+09:00
        [JsonProperty]
        public string? UpdateTime { get; set; }

        [JsonProperty]
        public int? Revision { get; set; }
    }
}
