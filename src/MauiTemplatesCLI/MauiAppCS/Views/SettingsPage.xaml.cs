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
#if Net8OrLater
            var viewModel = AppService.GetService<SettingsViewModel>();
            viewModel.Title = "Settings";
            BindingContext = viewModel;
#else
            BindingContext = AppService.GetService<SettingsViewModel>();
#endif
#else
#if Net8OrLater
            viewModel.Title = "Settings";
#endif
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
