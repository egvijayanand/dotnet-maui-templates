#if IsFileScoped
namespace MyApp.Namespace;

#else
namespace MyApp.Namespace
{
#endif
#if IsInternal
#if IsPartial
#if IsAbstract
    internal abstract partial class MyClass__1 : object
#elif IsSealed
    internal sealed partial class MyClass__1 : object
#elif IsStatic
    internal static partial class MyClass__1 : object
#else
    internal partial class MyClass__1 : object
#endif
#else
#if IsAbstract
    internal abstract class MyClass__1 : object
#elif IsSealed
    internal sealed class MyClass__1 : object
#elif IsStatic
    internal static class MyClass__1 : object
#else
    internal class MyClass__1 : object
#endif
#endif
#elif IsProtected
#if IsPartial
#if IsAbstract
    protected abstract partial class MyClass__1 : object
#elif IsSealed
    protected sealed partial class MyClass__1 : object
#elif IsStatic
    protected static partial class MyClass__1 : object
#else
    protected partial class MyClass__1 : object
#endif
#else
#if IsAbstract
    protected abstract class MyClass__1 : object
#elif IsSealed
    protected sealed class MyClass__1 : object
#elif IsStatic
    protected static class MyClass__1 : object
#else
    protected class MyClass__1 : object
#endif
#endif
#elif IsPrivate
#if IsPartial
#if IsAbstract
    private abstract partial class MyClass__1 : object
#elif IsSealed
    private sealed partial class MyClass__1 : object
#elif IsStatic
    private static partial class MyClass__1 : object
#else
    private partial class MyClass__1 : object
#endif
#else
#if IsAbstract
    private abstract class MyClass__1 : object
#elif IsSealed
    private sealed class MyClass__1 : object
#elif IsStatic
    private static class MyClass__1 : object
#else
    private class MyClass__1 : object
#endif
#endif
#else
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
#endif
    {
#if IsAbstract
        public MyClass__1()
#elif IsStatic
        static MyClass__1()
#else
        public MyClass__1()
#endif
        {
            
        }
    }
#if (!IsFileScoped)
}
#endif
