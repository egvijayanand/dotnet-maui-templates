using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Avalonia.Controls.Maui.Platform;
using Microsoft.Maui.Hosting;
using System.Globalization;

namespace MauiApp._1
{
    public class AvaApp : MauiAvaloniaApplication
    {
        public override void Initialize() => AvaloniaXamlLoader.Load(this);

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp(useSingleAppLifetime: true);
    }
}
