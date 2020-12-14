using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCUAPI.API.Models
{
    class SummonerObject
    {
        public class RerollPoints
        {

            [JsonProperty("currentPoints")]
            public int CurrentPoints { get; set; }

            [JsonProperty("maxRolls")]
            public int MaxRolls { get; set; }

            [JsonProperty("numberOfRolls")]
            public int NumberOfRolls { get; set; }

            [JsonProperty("pointsCostToRoll")]
            public int PointsCostToRoll { get; set; }

            [JsonProperty("pointsToReroll")]
            public int PointsToReroll { get; set; }
        }

        public class Summoner
        {

            [JsonProperty("accountId")]
            public long AccountId { get; set; }

            [JsonProperty("displayName")]
            public string DisplayName { get; set; }

            [JsonProperty("internalName")]
            public string InternalName { get; set; }

            [JsonProperty("nameChangeFlag")]
            public bool NameChangeFlag { get; set; }

            [JsonProperty("percentCompleteForNextLevel")]
            public int PercentCompleteForNextLevel { get; set; }

            [JsonProperty("profileIconId")]
            public int ProfileIconId { get; set; }

            [JsonProperty("puuid")]
            public string Puuid { get; set; }

            [JsonProperty("rerollPoints")]
            public RerollPoints RerollPoints { get; set; }

          /*  [JsonProperty("summonerId")]
            public int SummonerId { get; set; }*/  // eror id summoner search


            [JsonProperty("summonerLevel")]
            public int SummonerLevel { get; set; }

            [JsonProperty("unnamed")]
            public bool Unnamed { get; set; }

            [JsonProperty("xpSinceLastLevel")]
            public int XpSinceLastLevel { get; set; }

            [JsonProperty("xpUntilNextLevel")]
            public int XpUntilNextLevel { get; set; }
        }
    }

    class SummonerProfile
    {
        [JsonProperty("backgroundSkinId")]
        public int BackgroundSkinId { get; set; }

        [JsonProperty("regalia")]
        public string Regalia { get; set; }
    }
}
