using TPlatformView = Android.Views.View;

namespace $rootnamespace$
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
