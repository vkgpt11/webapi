using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApiExceptionHandling.Response
{
    public class ErrorResponse
    {
        public HttpStatusCode StatusCode { get; set; }

        public ErrorResponseModel ErrorResponseModel { get; set; }
    }
}
