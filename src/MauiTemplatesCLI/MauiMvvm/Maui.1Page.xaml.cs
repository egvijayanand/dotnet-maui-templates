#if (!SameFolder)
using MyApp.Namespace.ViewModels;

#endif
#if SameFolder
namespace MyApp.Namespace
#else
namespace MyApp.Namespace.Views
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
