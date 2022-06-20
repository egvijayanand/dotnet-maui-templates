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

using $basenamespace$.Controls;

namespace $rootnamespace$
{
    public partial class $safeitemname$ : I$safeitemname$
    {
        public static IPropertyMapper<I$fileinputname$, I$safeitemname$> $fileinputname$Mapper
            = new PropertyMapper<I$fileinputname$, I$safeitemname$>(ViewMapper)
            {
                
            };

        /*public static CommandMapper<I$fileinputname$, I$safeitemname$> CommandMapper = new(ViewCommandMapper)
        {
        };*/

        public $safeitemname$() : base($fileinputname$Mapper)
        {
            
        }

        public $safeitemname$(IPropertyMapper? mapper = null) : base(mapper ?? $fileinputname$Mapper)
        {
            
        }

        I$fileinputname$ I$safeitemname$.VirtualView => VirtualView;

        // TODO: PlatformView definition
        TPlatformView I$safeitemname$.PlatformView => PlatformView;
    }
}
