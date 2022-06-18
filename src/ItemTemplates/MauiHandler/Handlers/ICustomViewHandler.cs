#if ANDROID
using TPlatformView = Android.Views.View;
#elif IOS || MACCATALYST
using TPlatformView = UIKit.UIView;
#elif TIZEN
using TPlatformView = System.Object;
#elif WINDOWS
using TPlatformView = Microsoft.UI.Xaml.FrameworkElement;
#elif NETSTANDARD || !PLATFORM || (NET6_0_OR_GREATER && !IOS && !ANDROID && !TIZEN)
using TPlatformView = System.Object;
#endif

namespace $rootnamespace$
{
    public partial interface $safeitemname$ : IViewHandler
    {
        new I$fileinputname$ VirtualView { get; }

        // TODO: PlatformView definition
        new TPlatformView PlatformView { get; }
    }
}
