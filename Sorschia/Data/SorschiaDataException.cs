using System;
using System.Runtime.Serialization;

namespace Sorschia.Data
{
    public class SorschiaDataException : SorschiaException
    {
        public SorschiaDataException()
        {
        }

        public SorschiaDataException(string message) : base(message)
        {
        }

        public SorschiaDataException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SorschiaDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
