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
            Resources.Add("PageBackgroundColor", Color.FromArgb("#512BDF"));
            Resources.Add("PrimaryTextColor", Colors.White);

            Resources.Add(new Style(typeof(Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = Resources["PrimaryTextColor"] },
                    new() { Property = Label.FontFamilyProperty, Value = "OSR" }
                }
            });

            Resources.Add(new Style(typeof(Button))
            {
                Setters =
                {
                    new() { Property = Button.TextColorProperty, Value = Resources["PrimaryTextColor"] },
                    new() { Property = Button.FontFamilyProperty, Value = "OSR" },
                    new() { Property = VisualElement.BackgroundColorProperty, Value = Color.FromArgb("#2B0B98") },
                    new() { Property = Button.PaddingProperty, Value = new Thickness(14,10) }
                }
            });
        }
	}
}
