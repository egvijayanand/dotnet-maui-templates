using TPlatformView = Android.Views.View;
using $base_namespace$.Controls;
using Microsoft.Maui.Handlers;

namespace $base_namespace$.Handlers
{
    public partial class $safeitemname$ : ViewHandler<I$fileinputname$, TPlatformView>
    {
        protected override TPlatformView CreatePlatformView() => new TPlatformView(Context);

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
