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
            BindingContext = AppService.GetService<SearchViewModel>();
#else
            viewModel.Title = "Search";
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
