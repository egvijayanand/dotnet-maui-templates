#if RootFolder
namespace MyApp.RootNamespace
#else
namespace MyApp.Namespace
#endif
{
#if IsGeneric
    public partial class MauiItem__1 : ContentView<TContext>
#else
    public partial class MauiItem__1 : ContentView
#endif
    {
        public MauiItem__1()
        {
            InitializeComponent();
        }
    }
}
