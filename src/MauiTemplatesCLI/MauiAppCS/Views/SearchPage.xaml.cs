namespace MauiApp._1.Views
{
    public partial class SearchPage : ContentPage
    {
#if Mvvm
#if Tabbed
        public SearchPage()
#else
        public SearchPage(SearchViewModel viewModel)
#endif
        {
            InitializeComponent();
#if Tabbed
#if Net8OrLater
            var viewModel = AppService.GetService<SearchViewModel>();
            viewModel.Title = "Search";
            BindingContext = viewModel;
#else
            BindingContext = AppService.GetService<SearchViewModel>();
#endif
#else
#if Net8OrLater
            viewModel.Title = "Search";
#endif
            BindingContext = viewModel;
#endif
        }
#else
        public SearchPage()
        {
            InitializeComponent();
        }
#endif
    }
}
