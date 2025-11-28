#if RootFolder
namespace MyApp.RootNamespace
#else
namespace MyApp.Namespace
#endif
{
    public partial class MauiShell__1Shell : Shell
    {
        public MauiShell__1Shell()
        {
            InitializeComponent();
        }

#if AddComments
        // UnComment the below method to handle Shell Menu item click event
        // And ensure appropriate page definitions are available for it work as expected
#endif
        //private async void OnMenuItemClicked(object? sender, EventArgs e)
        //{
        //    await Current.GoToAsync("//login");
        //}
    }
}
