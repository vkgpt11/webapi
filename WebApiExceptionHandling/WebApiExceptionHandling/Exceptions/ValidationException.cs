using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExceptionHandling.Exceptions
{
    public class ValidationException : CoreException
    {
        public IEnumerable<string> Errors { get; set; }

        public static string GetGenericInstantiationError(string instanceType)
                        => $"Validation error/s occured while creating {instanceType} instance";

        public ValidationException(string message) : base(message)
        {

        }

        public ValidationException(string message, IEnumerable<string> errors) : base(message)
        {
            Errors = errors;
        }
    }
}
