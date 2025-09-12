//-:cnd:noEmit
#if FORMS
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace System.Runtime.CompilerServices;

internal sealed class IsExternalInit {}
#endif
#if MAUI
//+:cnd:noEmit
#if Net10OrLater

[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/maui/global", "SharedClassLib._1")]
#else
// .NET MAUI Options
#endif
//-:cnd:noEmit
#endif
//+:cnd:noEmit
