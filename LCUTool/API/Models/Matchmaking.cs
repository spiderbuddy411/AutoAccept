﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCUAPI.API.Models
{
    class Matchmaking
    {
        public class ReadyCheck
        {
            [JsonProperty("declinerIds")]
            public List<object> DeclinerIds { get; set; }

            [JsonProperty("dodgeWarning")]
            public string DodgeWarning { get; set; }

            [JsonProperty("playerResponse")]
            public string PlayerResponse { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("suppressUx")]
            public bool SuppressUx { get; set; }

            [JsonProperty("timer")]
            public double Timer { get; set; }
        }
    }
}
