using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Application = Microsoft.Maui.Controls.Application;
using WinApp = Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific.Application;

namespace $ext_safeprojectname$
{
	public partial class App : Application
	{
		public App()
		{
			Build();

			MainPage = new MainPage();
		}
		
		private void Build()
        {
            WinApp.SetImageDirectory(this, "Assets");
            Resources.Add("PrimaryColor", Color.FromArgb("#512BDF"));
            Resources.Add("SecondaryColor", Colors.White);

            Resources.Add(new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Resources["PrimaryColor"] },
                    new() { Property = Label.FontFamilyProperty, Value = "OpenSansRegular" }
                }
            });

            Resources.Add(new Style(typeof(Button))
            {
                Setters =
                {
                    new() { Property = Button.TextColorProperty, Value = Resources["SecondaryColor"] },
                    new() { Property = Button.FontFamilyProperty, Value = "OpenSansRegular" },
                    new() { Property = VisualElement.BackgroundColorProperty, Value = Resources["PrimaryColor"] },
                    new() { Property = Button.PaddingProperty, Value = new Thickness(14,10) }
                }
            });
        }
	}
}
