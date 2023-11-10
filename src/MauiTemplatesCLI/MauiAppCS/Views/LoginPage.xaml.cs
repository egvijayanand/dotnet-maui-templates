namespace MauiApp._1.Views
{
    public partial class LoginPage : ContentPage
    {
#if Mvvm
        public LoginPage(LoginViewModel viewModel)
        {
            InitializeComponent();
#if Net8OrLater
            viewModel.Title = "Login";
#endif
            BindingContext = viewModel;
        }
#else
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//home");
        }
#endif
    }
}
