using System;
using System.Runtime.Serialization;

namespace Sorschia.Security
{
    public class SorschiaSecurityException : SorschiaException
    {
        public SorschiaSecurityException()
        {
        }

        public SorschiaSecurityException(string message) : base(message)
        {
        }

        public SorschiaSecurityException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SorschiaSecurityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
