using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApiExceptionHandling.Exceptions
{
    public class EntityDoesNotExistException: CoreException
    {
        public Guid Id { get; }
        public Type EntityType { get; }
        public EntityDoesNotExistException(string message, Type entiyType):base(message)
        {

        }

        public EntityDoesNotExistException(Guid id, Type entityType)
        {
            Id = id;
            EntityType = entityType;
        }

        public EntityDoesNotExistException(string messgae, Guid id, Type entityType):base(messgae)
        {
            Id = id;
            EntityType = entityType;
        }
        public EntityDoesNotExistException(string messgae, Exception innerException, Guid id, Type entityType) : base(messgae, innerException)
        {
            Id = id;
            EntityType = entityType;
        }
        public EntityDoesNotExistException(SerializationInfo info, StreamingContext context, Guid id, Type entityType) : base(info, context)
        {
            Id = id;
            EntityType = entityType;
        }


    }
}
