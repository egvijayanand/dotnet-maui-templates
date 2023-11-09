using Microsoft.Maui.Primitives;

namespace MauiApp._1.Extensions
{
    public static class ViewExtensions
    {
        public static TView Center<TView>(this TView view) where TView : View
        {
            view.SetEnvironment(EnvironmentKeys.Layout.HorizontalLayoutAlignment, LayoutAlignment.Center, false);
            view.SetEnvironment(EnvironmentKeys.Layout.VerticalLayoutAlignment, LayoutAlignment.Center, false);
            return view;
        }
    }
}
