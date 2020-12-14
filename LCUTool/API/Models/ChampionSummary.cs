using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCUAPI.API.Models
{
    public class MyArray
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("squarePortraitPath")]
        public string SquarePortraitPath { get; set; }

        [JsonProperty("roles")]
        public List<string> Roles { get; set; }
    }

    public class ChampionSummary
    {
        [JsonProperty("MyArray")]
        public List<MyArray> MyArray { get; set; }
    }
}
