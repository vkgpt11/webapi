using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExceptionHandling.Response
{
    public class BadRequestResposeModel : ErrorResponseModel
    {
        [JsonProperty(NullValueHandling =NullValueHandling.Ignore)]
        public IEnumerable<string> Errors { get; set; }
    }
}
