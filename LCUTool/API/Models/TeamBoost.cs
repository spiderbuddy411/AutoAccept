using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCUAPI.API.Models
{
    public class ImplementationDetails
    {
    }

    public class TeamBoost
    {
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("httpStatus")]
        public int HttpStatus { get; set; }

        [JsonProperty("implementationDetails")]
        public ImplementationDetails ImplementationDetails { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
