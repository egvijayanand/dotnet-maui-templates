using TPlatformView = System.Object;
using $basenamespace$.Controls;
using Microsoft.Maui.Handlers;

namespace $rootnamespace$
{
    public partial class $safeitemname$ : ViewHandler<I$fileinputname$, TPlatformView>
    {
        // PlatformParent need to be passed as an input parameter for a Tizen view
        // Uncomment it once actual Tizen platform type is mapped
        protected override TPlatformView CreatePlatformView() => new TPlatformView(/*PlatformParent*/);

        protected override void ConnectHandler(TPlatformView platformView)
        {
            base.ConnectHandler(platformView);
        }

        protected override void DisconnectHandler(TPlatformView platformView)
        {
            base.DisconnectHandler(platformView);
        }
    }
}
