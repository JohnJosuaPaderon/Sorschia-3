using System;
using System.Runtime.Serialization;

namespace Sorschia.Caching
{
    public class SorschiaCachingException : SorschiaException
    {
        public SorschiaCachingException()
        {
        }

        public SorschiaCachingException(string message) : base(message)
        {
        }

        public SorschiaCachingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SorschiaCachingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
