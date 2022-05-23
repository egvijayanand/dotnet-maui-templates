#if AddMvvmToolkit
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
#endif

//-:cnd:noEmit
// Based on constants defined in the project file
// Can also be defined using TargetFrameworkVersion like NETSTANDARD2_0, NETSTANDARD2_0_OR_GREATER,
// NET6_0, NET6_0_OR_GREATER, but requires certain changes to the project file while referencing it.
#if FORMS
// Xamarin.Forms specific using statements
#endif

#if MAUI
// .NET MAUI specific using statements
#endif
//+:cnd:noEmit
