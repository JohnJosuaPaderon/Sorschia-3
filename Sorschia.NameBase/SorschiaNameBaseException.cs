using System;
using System.Runtime.Serialization;

namespace Sorschia
{
    public class SorschiaNameBaseException : SorschiaException
    {
        public SorschiaNameBaseException()
        {
        }

        public SorschiaNameBaseException(string message) : base(message)
        {
        }

        public SorschiaNameBaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SorschiaNameBaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
