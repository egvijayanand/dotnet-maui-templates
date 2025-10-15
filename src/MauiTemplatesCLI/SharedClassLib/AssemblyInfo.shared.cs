//-:cnd:noEmit
#if FORMS
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace System.Runtime.CompilerServices;

internal sealed class IsExternalInit {}
#endif
#if MAUI
//+:cnd:noEmit
#if Net10OrLater

// Implicit Namespace option
// To enable, uncomment the below two lines.
//[assembly: System.Runtime.Versioning.RequiresPreviewFeatures]
//[assembly: Microsoft.Maui.Controls.Xaml.Internals.AllowImplicitXmlnsDeclaration]
// Alternatively, this can be done in the project file also.
// Set the EnablePreviewFeatures node and assign its value to true.
// And then define this constant: MauiAllowImplicitXmlnsDeclaration

// CLR Namespaces
[assembly: XmlnsDefinition("http://schemas.microsoft.com/dotnet/maui/global", "SharedClassLib._1")]
#else
// .NET MAUI Options
#endif
//-:cnd:noEmit
#endif
//+:cnd:noEmit
