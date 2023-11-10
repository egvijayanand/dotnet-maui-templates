using System.Runtime.Serialization;

namespace MauiApp._1.Exceptions
{
    [Serializable]
    public class RouteNotFoundException : Exception
    {
        public RouteNotFoundException() { }
        public RouteNotFoundException(string message) : base(message) { }
        public RouteNotFoundException(string message, Exception inner) : base(message, inner) { }
#if Net8OrLater
        [Obsolete]
#endif
        protected RouteNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
