using TPlatformView = UIKit.UIView;

namespace $rootnamespace$
{
    public partial class $safeitemname$ : ViewHandler<I$fileinputname$, TPlatformView>
    {
        protected override TPlatformView CreatePlatformView() => new TPlatformView();

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
