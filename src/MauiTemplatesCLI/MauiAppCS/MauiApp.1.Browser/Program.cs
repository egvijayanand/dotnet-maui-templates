using Avalonia;
using Avalonia.Browser;
using Avalonia.Controls;
using Avalonia.Controls.Maui;

namespace MauiApp._1
{
    internal sealed partial class Program
    {
        private static Task Main(string[] args)
            => BuildAvaloniaApp().WithInterFont().StartBrowserAppAsync("out");
    
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<AvaApp>();
    }
}
