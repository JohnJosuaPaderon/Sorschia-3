using System;
using System.Runtime.Serialization;

namespace Sorschia.Convention
{
    public class SorschiaConventionException : SorschiaException
    {
        public SorschiaConventionException()
        {
        }

        public SorschiaConventionException(string message) : base(message)
        {
        }

        public SorschiaConventionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SorschiaConventionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
