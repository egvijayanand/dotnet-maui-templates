### Project and Item Templates for developing .NET MAUI App that runs on iOS, Android, macOS, and Windows 

All-in-One project template for .NET MAUI App and is named as `mauiapp`

.NET MAUI Class Library project template and is named as `mauiclasslib`

Item templates for the following:

|Item|Template Name|
|:---:|:---:|
|ContentPage (XAML)|maui-page|
|ContentPage (C#)|maui-page-cs|
|ContentView (XAML)|maui-view|
|ContentView (C#)|maui-view-cs|
|Shell (XAML)|maui-shell|
|ResourceDictionary (XAML)|maui-resdict|

All of these templates currently target `.NET MAUI RC3`, latest release as of May 2022.

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

Use the below .NET CLI command to create the all-in-one .NET MAUI App, library project, pages, and views out these templates:

*Note: Parameter values are case-insensitive.*

Both project templates take the below optional parameters to include the official CommunityToolkit NuGet packages:

* `-it` | `--include-toolkit` - Accepted Values are `Yes` or `No` (default is `No`)
* `-im` | `--include-markup` - Accepted Values are `Yes` or `No` (default is `No`)
* `-imt` | `--include-mvvm-toolkit` - Accepted Values are `Yes` or `No` (default is `No`)

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

For more details: run this command in the terminal (use `-h` to save some keystrokes):

```shell
dotnet new mauiapp --help
```
```shell
dotnet new mauiclasslib --help
```

.NET MAUI App:
```shell
dotnet new mauiapp -n MyApp -dp Hybrid
```
Option to include NuGet packages:
```shell
dotnet new mauiapp -n MyApp -dp Shell -it yes -im yes -imt yes
```

.NET MAUI Class Library:
```shell
dotnet new mauiclasslib -n MyApp.Core
```
Option to include NuGet packages:
```shell
dotnet new mauiclasslib -n MyApp.Core -it yes -im yes -imt yes
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
