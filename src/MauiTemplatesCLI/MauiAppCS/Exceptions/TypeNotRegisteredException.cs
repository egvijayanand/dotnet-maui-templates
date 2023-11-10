using System.Runtime.Serialization;

namespace MauiApp._1.Exceptions
{
    [Serializable]
    public class TypeNotRegisteredException : Exception
    {
        public TypeNotRegisteredException() { }
        public TypeNotRegisteredException(string message) : base(message) { }
        public TypeNotRegisteredException(string message, Exception inner) : base(message, inner) { }
#if Net8OrLater
            [Obsolete]
#endif
        protected TypeNotRegisteredException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
