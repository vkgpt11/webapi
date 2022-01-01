using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExceptionHandling.Exceptions.ExceptionBuilder;

namespace WebApiExceptionHandling.Exceptions.Handler
{
    enum ExceptionTypes
    {
        CoreError,
        EntityDoesNotExist,
        Validation,
        Unique,
    }

    public class ErrorResponseBuilderFactory : IErrorResponseBuilderFactory
    {

        public IErrorResponseBuilder Create(Type exceptionType)
        {
            switch (exceptionType)
            {
                case ExceptionTypes.CoreError:
                    return new CoreErrorResponseBuilder();
                case ExceptionTypes.EntityDoesNotExist()
            }
        }
    }
}
