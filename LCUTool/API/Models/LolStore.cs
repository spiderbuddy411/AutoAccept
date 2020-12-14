using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCUAPI.API.Models
{
    class LolStore
    {
        public class Wallet
        {
            [JsonProperty("ip")]
            public int BlueEssence { get; set; }

            [JsonProperty("rp")]
            public int RP { get; set; }
        }
    }
}
