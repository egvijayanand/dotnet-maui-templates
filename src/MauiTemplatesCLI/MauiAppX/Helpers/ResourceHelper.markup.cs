#if Mvu
using Microsoft.Maui.Controls;

#endif
namespace MauiApp._1.Helpers
{
    public static class ResourceHelper
    {
        public static T? AppResource<T>(string key)
        {
            if (Application.Current?.Resources.TryGetValue(key, out var value) is true)
            {
                return (value is T resource) ? resource : default;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(key), $"StaticResource not found for key {key}");
            }
        }

        public static Color? AppColor(string resourceKey) => AppResource<Color>(resourceKey);

        public static IValueConverter? AppConverter(string resourceKey) => AppResource<IValueConverter>(resourceKey);

        public static Style? AppStyle(string resourceKey) => AppResource<Style>(resourceKey);

        public static object AppResource(string key)
        {
            if (Application.Current?.Resources.TryGetValue(key, out var value) is true)
            {
                return value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(key), $"StaticResource not found for key {key}");
            }
        }
    }
}
