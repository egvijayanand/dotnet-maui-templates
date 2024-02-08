#if RootFolder
namespace MyApp.RootNamespace
#else
namespace MyApp.Namespace
#endif
{
#if IsGeneric
    public partial class MauiItem__1 : ContentPage<TObject>
#else
    public partial class MauiItem__1 : ContentPage
#endif
    {
        public MauiItem__1()
        {

        }
    }
}
