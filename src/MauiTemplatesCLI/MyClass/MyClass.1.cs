namespace MyApp.Namespace
{
#if IsPartial
#if IsAbstract
    public abstract partial class MyClass__1 : object
#elif IsSealed
    public sealed partial class MyClass__1 : object
#elif IsStatic
    public static partial class MyClass__1 : object
#else
    public partial class MyClass__1 : object
#endif
#else
#if IsAbstract
    public abstract class MyClass__1 : object
#elif IsSealed
    public sealed class MyClass__1 : object
#elif IsStatic
    public static class MyClass__1 : object
#else
    public class MyClass__1 : object
#endif
#endif
    {
#if IsStatic
        static MyClass__1()
#else
        public MyClass__1()
#endif
        {
            
        }
    }
}
