using Microsoft.Maui.Graphics;

namespace MauiApp._1
{
    public class AppColors : ResourceDictionary
    {
        private static AppColors? _instance;

        protected AppColors()
        {
            Add("Primary", Color.FromArgb("#512BD4"));
            Add("Secondary", Color.FromArgb("#DFD8F7"));
            Add("Tertiary", Color.FromArgb("#2B0B98"));
            Add("White", Colors.White);
            Add("Black", Colors.Black);
            Add("Gray100", Color.FromArgb("#E1E1E1"));
            Add("Gray200", Color.FromArgb("#C8C8C8"));
            Add("Gray300", Color.FromArgb("#ACACAC"));
            Add("Gray400", Color.FromArgb("#919191"));
            Add("Gray500", Color.FromArgb("#6E6E6E"));
            Add("Gray600", Color.FromArgb("#404040"));
            Add("Gray900", Color.FromArgb("#212121"));
            Add("Gray950", Color.FromArgb("#141414"));
            Add("Light", Color.FromArgb("#DFD8F7"));
            Add("Dark", Color.FromArgb("#2B0B98"));
            Add("LightGray", Color.FromArgb("#E5E5E1"));
            Add("MidGray", Color.FromArgb("#969696"));
            Add("DarkGray", Color.FromArgb("#505050"));
            Add("PrimaryBrush", new SolidColorBrush((Color)this["Primary"]));
            Add("SecondaryBrush", new SolidColorBrush((Color)this["Secondary"]));
            Add("TertiaryBrush", new SolidColorBrush((Color)this["Tertiary"]));
            Add("WhiteBrush", new SolidColorBrush((Color)this["White"]));
            Add("BlackBrush", new SolidColorBrush((Color)this["Black"]));
            Add("Gray100Brush", new SolidColorBrush((Color)this["Gray100"]));
            Add("Gray200Brush", new SolidColorBrush((Color)this["Gray200"]));
            Add("Gray300Brush", new SolidColorBrush((Color)this["Gray300"]));
            Add("Gray400Brush", new SolidColorBrush((Color)this["Gray400"]));
            Add("Gray500Brush", new SolidColorBrush((Color)this["Gray500"]));
            Add("Gray600Brush", new SolidColorBrush((Color)this["Gray600"]));
            Add("Gray900Brush", new SolidColorBrush((Color)this["Gray900"]));
            Add("Gray950Brush", new SolidColorBrush((Color)this["Gray950"]));
            Add("LightBrush", new SolidColorBrush((Color)this["Light"]));
            Add("DarkBrush", new SolidColorBrush((Color)this["Dark"]));
            Add("LightGrayBrush", new SolidColorBrush((Color)this["LightGray"]));
            Add("MidGrayBrush", new SolidColorBrush((Color)this["MidGray"]));
            Add("DarkGrayBrush", new SolidColorBrush((Color)this["DarkGray"]));
            Add("BackgroundDark", Color.FromArgb("#121212"));
            Add("BackgroundLight", Colors.White);
            Add("TextDark", Colors.White);
            Add("TextLight", Colors.Black);
            Add("Yellow100Accent", Color.FromArgb("#F7B548"));
            Add("Yellow200Accent", Color.FromArgb("#FFD590"));
            Add("Yellow300Accent", Color.FromArgb("#FFE5B9"));
            Add("Cyan100Accent", Color.FromArgb("#28C2D1"));
            Add("Cyan200Accent", Color.FromArgb("#7BDDEF"));
            Add("Cyan300Accent", Color.FromArgb("#C3F2F4"));
            Add("Blue100Accent", Color.FromArgb("#3E8EED"));
            Add("Blue200Accent", Color.FromArgb("#72ACF1"));
            Add("Blue300Accent", Color.FromArgb("#A7CBF6"));
        }

        public static AppColors Instance => _instance ??= new AppColors();
    }
}
