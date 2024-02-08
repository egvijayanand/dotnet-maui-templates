#if (!SameFolder)
using MyApp.RootNamespace.ViewModels;

#endif
#if SameFolder
#if RootFolder
namespace MyApp.RootNamespace
#else
namespace MyApp.Namespace
#endif
#else
namespace MyApp.RootNamespace.Views
#endif
{
    public partial class Maui__1Page : ContentPage
    {
        public Maui__1Page(Maui__1ViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
