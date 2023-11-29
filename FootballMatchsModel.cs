using Newtonsoft.Json;

namespace Questao2
{
    public partial class FootballMatchs
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("data")]
        public MatchModel[] Data { get; set; }
    }
}
