namespace MauiApp._1.Views
{
    public partial class SettingsPage : ContentPage
    {
#if Mvvm
#if Tabbed
        public SettingsPage()
#else
        public SettingsPage(SettingsViewModel viewModel)
#endif
        {
            InitializeComponent();
#if Tabbed
            BindingContext = AppService.GetService<SettingsViewModel>();
#else
            viewModel.Title = "Settings";
            BindingContext = viewModel;
#endif
        }
#else
        public SettingsPage()
        {
            InitializeComponent();
        }
#endif
    }
}
