using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExceptionHandling.Exceptions.ExceptionBuilder;

namespace WebApiExceptionHandling.Exceptions.Handler
{
    public interface IErrorResponseBuilderFactory
    {
        IErrorResponseBuilder Create(Type exceptionType);
    }
}
