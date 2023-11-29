using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Questao2
{
    public class MatchModel
    {

        [JsonProperty("competition")]
        public string Competition { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }

        [JsonProperty("team1")]
        public string Team1 { get; set; }

        [JsonProperty("team2")]
        public string Team2 { get; set; }

        [JsonProperty("team1goals")]
        public long Team1Goals { get; set; }

        [JsonProperty("team2goals")]
        public long Team2Goals { get; set; }
    }
}