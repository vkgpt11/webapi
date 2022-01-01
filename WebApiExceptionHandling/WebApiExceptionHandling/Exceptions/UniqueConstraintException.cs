using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExceptionHandling.Exceptions
{
    public class UniqueConstraintException : Exception
    {
        public Dictionary<string, string> Properties { get; }
        public UniqueConstraintException(
            Dictionary<string,string> props,
            Exception innerException
            ) :base(nameof(UniqueConstraintException), innerException)
        {
            Properties = props;
        }
    }
}
