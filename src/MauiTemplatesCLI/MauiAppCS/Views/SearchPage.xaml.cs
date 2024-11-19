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
            var viewModel = AppService.GetRequiredService<SearchViewModel>();
#endif
            viewModel.Title = "Search";
            BindingContext = viewModel;
        }
#else
        public SearchPage()
        {
            InitializeComponent();
        }
#endif
    }
}
