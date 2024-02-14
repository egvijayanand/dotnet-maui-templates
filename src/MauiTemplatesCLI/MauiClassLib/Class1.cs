﻿namespace MauiClassLib._1
{
    public partial class Class1
    {
#if UseMaui
        public partial void DoWork();

#endif
//-:cnd:noEmit
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
//+:cnd:noEmit
        // Code block for unsupported Platforms
#if UseMaui
        public partial void DoWork()
        {
            // Could even be like the below exception
            //throw new PlatformNotSupportedException();
        }
#endif
//-:cnd:noEmit
#endif
//+:cnd:noEmit
    }
}
