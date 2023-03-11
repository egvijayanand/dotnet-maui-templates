namespace MauiApp._1.Views
{
    public partial class LoginPage : ContentPage
    {
#if Mvvm
        public LoginPage(LoginViewModel viewModel)
        {
            InitializeComponent();
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
