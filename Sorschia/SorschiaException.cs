using System;
using System.Runtime.Serialization;

namespace Sorschia
{
    public class SorschiaException : Exception
    {
        public SorschiaException()
        {
        }

        public SorschiaException(string message) : base(message)
        {
        }

        public SorschiaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SorschiaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
