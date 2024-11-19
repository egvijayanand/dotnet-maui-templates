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
            var viewModel = AppService.GetRequiredService<SettingsViewModel>();
#endif
            viewModel.Title = "Settings";
            BindingContext = viewModel;
        }
#else
        public SettingsPage()
        {
            InitializeComponent();
        }
#endif
    }
}
