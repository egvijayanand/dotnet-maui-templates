### Project and Item Templates for developing .NET MAUI App that runs on iOS, Android, macOS, and Windows 

* All-in-One project template for .NET MAUI App and is named as `mauiapp`
* .NET MAUI Class Library project template and is named as `mauiclasslib`
* Shared Class Library (Xamarin.Forms and .NET MAUI) project template and is named as `sharedclasslib`

Item templates for the following:

|Item|Template Name|
|:---:|:---:|
|ContentPage (XAML)|maui-page|
|ContentPage (C#)|maui-page-cs|
|ContentView (XAML)|maui-view|
|ContentView (C#)|maui-view-cs|
|Shell (XAML)|maui-shell|
|ResourceDictionary (XAML)|maui-resdict|

All of these templates currently target `.NET MAUI GA`, stable release as of May 2022.

To install the template NuGet package, use the below .NET CLI command:

```shell
dotnet new --install VijayAnand.MauiTemplates
```

If you've already installed this package, then it can be updated to the latest version with the below command:

```shell
dotnet new --update-check
```
```shell
dotnet new --update-apply
```

Use the below .NET CLI command to create the All-in-One .NET MAUI App, library project, pages, and views out these templates:

*Note: Parameter values are case-insensitive.*

Both .NET MAUI *App* and *Class Library* templates take the below optional Boolean parameters to include the officially supported CommunityToolkit NuGet packages:

And now conditional compilation can be configured so that platform source files can be defined anywhere in the project provided they follow a naming convention as mentioned below.

This will allow maintaining related source files in the same place, especially MAUI Handlers.

* \*.Standard.cs - Files targeting the BCL
* \*.Android.cs - Files specific to Android
* \*.iOS.cs - Files shared with both iOS and MacCatalyst
* \*.MacCatalyst.cs - Files specific to MacCatalyst
* \*.Tizen.cs - Files specific to Tizen
* \*.Windows.cs - Files specific to Windows

*Specifying the parameter name, either in short or full notation, implies that it is defined.*

* `-it` | `--include-toolkit` - Default is `false`
* `-im` | `--include-markup` - Default is `false`
* `-imt` | `--include-mvvm-toolkit` - Default is `false`
* `-cc` | `--conditional-compilation` - Default is `false`

All-in-One .NET MAUI App project takes one additional parameter to define the application design pattern:

* `-dp` | `--design-pattern`

Can take any one of the following values, with default value set to `Plain`:

|Parameter Value|Description|
|:---:|:---|
|Plain|App configured to work with a single, initial screen.|
|Hierarchical|App configured to work in a hierarchical pattern using NavigationPage.|
|Tab|App configured to work in a Tabbed fashion using TabbedPage.|
|Shell|App configured to work with Routes using Shell page.|
|Hybrid|App configured to work in a Hybrid fashion using BlazorWebView.|

Shared Class Library template take the below optional Boolean parameters to include the officially supported NuGet packages:

*Specifying the parameter name, either in short or full notation, implies that it is defined.*

Single parameter to include all the supported NuGet packages:

* `-asp` | `--all-supported-packages` - Default is `false`

Specific to `Xamarin.Forms`:

* `-ife` | `--include-forms-essentials` - Default is `false`
* `-ift` | `--include-forms-toolkit` - Default is `false`
* `-ifm` | `--include-forms-markup` - Default is `false`

Specific to `.NET MAUI`:

* `-imt` | `--include-maui-toolkit` - Default is `false`
* `-imm` | `--include-maui-markup` - Default is `false`

Common to both:

* `-inmt` | `--include-mvvm-toolkit` - Default is `false`

For more details: run this command in the terminal (use `-h` to save some keystrokes):

```shell
dotnet new mauiapp --help
```
```shell
dotnet new mauiclasslib --help
```
```shell
dotnet new sharedclasslib --help
```

.NET MAUI App:
```shell
dotnet new mauiapp -n MyApp -dp Hybrid
```
Option to include NuGet packages:
```shell
dotnet new mauiapp -n MyApp -dp Shell -it -im -imt
```
Option to configure conditional compilation:
```shell
dotnet new mauiapp -n MyApp -dp Shell -cc
```

.NET MAUI Class Library:
```shell
dotnet new mauiclasslib -n MyApp.Core
```
Option to include NuGet packages:
```shell
dotnet new mauiclasslib -n MyApp.Core -it -im -imt
```
Option to configure conditional compilation:
```shell
dotnet new mauiclasslib -n MyApp.Core -cc
```

Shared Class Library:
```shell
dotnet new sharedclasslib -n MyApp.UI
```
Option to include all supported NuGet packages:
```shell
dotnet new sharedclasslib -n MyApp.UI -asp
```

Pages:
```shell
dotnet new maui-page -n LoginPage -na MyApp.Views
```
```shell
dotnet new maui-page-cs -n HomePage -na MyApp.Views
```

Views:
```shell
dotnet new maui-view -n CardView -na MyApp.Views
```
```shell
dotnet new maui-view-cs -n OrderView -na MyApp.Views
```

Shell:
```shell
dotnet new maui-shell -n AppShell -na MyApp
```

Resource Dictionary:

With code-behind C# file:
```shell
dotnet new maui-resdict -n DarkTheme -na MyApp
```
Without code-behind C# file (Here `-ncb` | `--no-code-behind` denotes the option to exclude the C# file):
```shell
dotnet new maui-resdict -n DarkTheme -na MyApp -ncb
```

In all the examples, `-n` denotes the name of the project/page/view that is to be created (for pages/views, don't need to suffix it with .xaml, it will be added automatically) (Can also be specified as `--name`).

*Note: If `name` parameter input is not provided, the .NET CLI template engine will take the current folder name in the context as its name (default behavior).*

And `-na` denotes the namespace under which the file is to be created (Can also be specified as `--namespace`).
