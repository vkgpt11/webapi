using System;

namespace WebApiExceptionHandling.Response
{
    public class ExceptionDetails
    {

        public string ExceptionMessage { get; set; }
        public string ExceptionType { get; set; }

        public string StackTrace { get; set; }

        public ExceptionDetails InnerException { get; set; }

        public static ExceptionDetails FromException(Exception ex)
        {
            var exceptionDetails = new ExceptionDetails
            {
                ExceptionMessage = ex.Message,
                ExceptionType = ex.GetType().FullName,
                StackTrace = ex.StackTrace,
                InnerException = ex.InnerException != null ? FromException(ex.InnerException) : null,
            };
            return exceptionDetails;
        }

    }
}