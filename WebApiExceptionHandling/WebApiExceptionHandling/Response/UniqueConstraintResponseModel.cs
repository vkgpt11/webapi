using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExceptionHandling.Response
{
    public class UniqueConstraintResponseModel: ErrorResponseModel
    {
        [JsonProperty(NullValueHandling =NullValueHandling.Ignore)]
        public Dictionary<string, string> UniqueConstraint { get; set; }

        public string UniqueConstraintKey { get; set; }
    }
}
