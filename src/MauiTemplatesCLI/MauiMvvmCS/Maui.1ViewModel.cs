#if SameFolder
#if RootFolder
namespace MyApp.RootNamespace
#else
namespace MyApp.Namespace
#endif
#else
namespace MyApp.RootNamespace.ViewModels
#endif
{
    public partial class Maui__1ViewModel : BaseViewModel
    {
        public Maui__1ViewModel()
        {
            
        }
    }
}
