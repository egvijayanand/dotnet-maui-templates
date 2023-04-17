namespace MauiClassLib._1
{
    public partial class Class1
    {
        public partial void DoSomething();

//-:cnd:noEmit
        // 
#if ANDROID
        // Code block for Android
#elif IOS
        // Code block for iOS
#elif MACCATALYST
        // Code block for Mac Catalyst
#elif TIZEN
        // Code block for Tizen
#elif WINDOWS
        // Code block for Windows
#else
        // Code block for Non-supported Platforms
        public partial void DoSomething()
        {
            // Could even be like the below exception
            //throw new PlatformNotSupportedException();
        }
#endif
//+:cnd:noEmit
    }
}
