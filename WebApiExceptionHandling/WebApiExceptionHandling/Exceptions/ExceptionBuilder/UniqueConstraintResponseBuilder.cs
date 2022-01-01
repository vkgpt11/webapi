using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExceptionHandling.Response;

namespace WebApiExceptionHandling.Exceptions.ExceptionBuilder
{
    public class UniqueConstraintResponseBuilder: IErrorResponseBuilder
    {
        public ErrorResponse Build(Exception ex)
        {
            var exception = (UniqueConstraintException)ex;
            return new ErrorResponse
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                ErrorResponseModel = new UniqueConstraintResponseModel
                {
                    ErrorCode = ErrorResponseStatusCode.UniqueConstraint,
                    Message = ex.Message,
                    UniqueConstraint = exception.Properties,
                    UniqueConstraintKey = string.Concat(exception.Properties.Keys.OrderBy(k=>k))
                },
            };
        }
    }
}
