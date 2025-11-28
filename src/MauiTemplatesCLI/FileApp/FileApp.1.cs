//-:cnd:noEmit
#if FileBasedProgram
//+:cnd:noEmit
#if Aspire
#:sdk Aspire.AppHost.Sdk@13.0.0
#elif BlazorWasm
#:sdk Microsoft.NET.Sdk.BlazorWebAssembly
#elif Razor
#:sdk Microsoft.NET.Sdk.Razor
#elif Web
#:sdk Microsoft.NET.Sdk.Web
#elif Worker
#:sdk Microsoft.NET.Sdk.Worker
#else
#:sdk Microsoft.NET.Sdk
#endif
// Properties
#:property TargetFramework=DOTNET_TFM
#if Preview
#:property LangVersion=preview
#endif
#if (Aspire && Maui)
// Packages
#:package Aspire.Hosting.AppHost@13.0.0
#:package Aspire.Hosting.Maui@13.*-*
#elif BlazorWasm
// Packages
#:package Microsoft.AspNetCore.Components.WebAssembly@PKG_VERSION
#:package Microsoft.AspNetCore.Components.WebAssembly.DevServer@PKG_VERSION
#elif Worker
// Packages
#:package Microsoft.Extensions.Hosting@PKG_VERSION
#endif
#if Aspire
// References
//#:project <path_to_your_project_file>
#endif
//-:cnd:noEmit
#endif
//+:cnd:noEmit

#if Aspire
#if Maui
using Aspire.Hosting.Maui;
using System.Runtime.InteropServices;

var builder = DistributedApplication.CreateBuilder(args);

// Configure builder
// Add MAUI to the pipeline
// Replace <your_proj_name> with the actual project name
// Replace <device_identifier> with the actual device identifier
if (IsWindows())
{
    builder.AddProject<Projects.<your_proj_name>>("mauiapp-windows")
        .WithEnvironment("TargetFramework", "DOTNET_TFM-windows10.0.19041.0")
        .WithIconName("Desktop");
}
else if (IsmacOS())
{
    builder.AddProject<Projects.<your_proj_name>>("mauiapp-ios")
        .WithEnvironment("TargetFramework", "DOTNET_TFM-ios")
        //.WithEnvironment("_DeviceName", "<device_identifier>")
        .WithIconName("PhoneTablet");
}
else if (IsLinux())
{
    builder.AddProject<Projects.<your_proj_name>>("mauiapp-android")
        .WithEnvironment("TargetFramework", "DOTNET_TFM-android")
        //.WithEnvironment("AdbTarget", "<device_identifier>")
        .WithIconName("PhoneTablet");
}

#else
var builder = DistributedApplication.CreateBuilder(args);

// Configure builder
//builder.AddProject<Projects.<your_proj_name>>("<resource_id>");

#endif
var aspire = builder.Build();
aspire.Run();
#if Maui

bool IsWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
bool IsmacOS() => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
bool IsLinux() => RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
#endif
#elif BlazorWasm
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Configure builder
//builder.RootComponents.Add<App>("#app");

await builder.Build().RunAsync();
#elif Web
var builder = WebApplication.CreateBuilder(args);

// Configure builder

var app = builder.Build();

// Configure app
app.MapGet("/", () => "Hello World!!!");

app.Run();
#elif Worker
var builder = Host.CreateApplicationBuilder(args);

// Configure builder
//builder.Services.AddHostedService<Worker>();

await builder.Build().RunAsync();
#else
Console.WriteLine("Hello World!!!");
#endif
