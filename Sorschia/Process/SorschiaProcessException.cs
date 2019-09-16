using System;
using System.Runtime.Serialization;

namespace Sorschia.Process
{
    public class SorschiaProcessException : SorschiaException
    {
        public SorschiaProcessException()
        {
        }

        public SorschiaProcessException(string message) : base(message)
        {
        }

        public SorschiaProcessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SorschiaProcessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
