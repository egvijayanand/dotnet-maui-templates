// For .NET 10 File-based Apps
//#:sdk Aspire.AppHost.Sdk@13.0.0
//#:package Aspire.Hosting.AppHost@13.0.0
//#:package Aspire.Hosting.Maui@13.*-*

//#:project ..\MauiApp.1\MauiApp.1.csproj

//using Aspire.Hosting;
using System.Runtime.InteropServices;

var builder = DistributedApplication.CreateBuilder(args);

// Configure builder
if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
#if (AllPlatforms || IsWindows)
    builder.AddProject<Projects.MauiApp._1>("mauiapp-windows")
        .WithEnvironment("TargetFramework", "MAUI_TFM-windows10.0.19041.0")
        .WithIconName("Desktop");
#elif (AllPlatforms || IsAndroid)
    builder.AddProject<Projects.MauiApp._1>("mauiapp-android")
        .WithEnvironment("TargetFramework", "MAUI_TFM-android")
        //.WithEnvironment("AdbTarget", "<android_device>")
        .WithIconName("PhoneTablet");
#elif (AllPlatforms || IsiOS)
    builder.AddProject<Projects.MauiApp._1>("mauiapp-ios")
        .WithEnvironment("TargetFramework", "MAUI_TFM-ios")
        //.WithEnvironment("_DeviceName", "<device_identifier>")
        .WithIconName("PhoneTablet");
#elif (AllPlatforms || IsmacOS)
    builder.AddProject<Projects.MauiApp._1>("mauiapp-macos")
        .WithEnvironment("TargetFramework", "MAUI_TFM-maccatalyst")
        //.WithEnvironment("_DeviceName", "<device_identifier>")
        .WithIconName("PhoneTablet");
#else
    builder.AddProject<Projects.MauiApp._1>("mauiapp");
#endif
}
else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
{
#if (AllPlatforms || IsiOS)
    builder.AddProject<Projects.MauiApp._1>("mauiapp-ios")
        .WithEnvironment("TargetFramework", "MAUI_TFM-ios")
        //.WithEnvironment("_DeviceName", "<device_identifier>")
        .WithIconName("PhoneTablet");
#elif (AllPlatforms || IsmacOS)
    builder.AddProject<Projects.MauiApp._1>("mauiapp-macos")
        .WithEnvironment("TargetFramework", "MAUI_TFM-maccatalyst")
        //.WithEnvironment("_DeviceName", "<device_identifier>")
        .WithIconName("PhoneTablet");
#elif (AllPlatforms || IsAndroid)
    builder.AddProject<Projects.MauiApp._1>("mauiapp-android")
        .WithEnvironment("TargetFramework", "MAUI_TFM-android")
        //.WithEnvironment("AdbTarget", "<android_device>")
        .WithIconName("PhoneTablet");
#else
    builder.AddProject<Projects.MauiApp._1>("mauiapp");
#endif
}
else
{
#if (AllPlatforms || IsAndroid)
    builder.AddProject<Projects.MauiApp._1>("mauiapp-android")
        .WithEnvironment("TargetFramework", "MAUI_TFM-android")
        //.WithEnvironment("AdbTarget", "<android_device>")
        .WithIconName("PhoneTablet");
#else
    builder.AddProject<Projects.MauiApp._1>("mauiapp");
#endif
}

var aspire = builder.Build();
aspire.Run();
