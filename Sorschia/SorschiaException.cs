using System;
using System.Runtime.Serialization;

namespace Sorschia
{
    public class SorschiaException : Exception
    {
        public SorschiaException(bool viewSafeMessage = false)
        {
            ViewSafeMessage = viewSafeMessage;
        }

        public SorschiaException(string message, bool viewSafeMessage = false) : base(message)
        {
            ViewSafeMessage = viewSafeMessage;
        }

        public SorschiaException(string message, Exception innerException, bool viewSafeMessage = false) : base(message, innerException)
        {
            ViewSafeMessage = viewSafeMessage;
        }

        protected SorschiaException(SerializationInfo info, StreamingContext context, bool viewSafeMessage = false) : base(info, context)
        {
            ViewSafeMessage = viewSafeMessage;
        }

        public bool ViewSafeMessage { get; set; }
    }
}
