## .NET MAUI All-in-One Templates Pack

### Project and Item Templates for .NET MAUI App that runs on Android, iOS, macOS, Windows, and Tizen

This repository is to host the .NET MAUI Project Templates, Item Templates, and Code Snippets.

Join me on [**Developer Thoughts**](https://egvijayanand.in/?utm_source=github&utm_medium=readme&utm_campaign=templates "Developer Thoughts"), an exclusive blog for .NET MAUI and Blazor, for [articles](https://egvijayanand.in/category/net-maui/templates-net-maui/?utm_source=github&utm_medium=readme&utm_campaign=templates) on working with these templates and much more.

We all know that .NET MAUI is an evolution of Xamarin.Forms.

Release Details:

|Channel|.NET MAUI Version|IDE Version|Release Date|Remarks|
|:---:|:---:|:---:|:---:|:---:|
|Stable|.NET 6 SR11 (6.0.553)|VS2022 17.4.x - 17.8.x|Tue, Apr 25, 2023|[Out of Support](https://dotnet.microsoft.com/en-us/platform/support/policy/maui ".NET MAUI Support Policy")|
|Stable|.NET 7 SR10 (7.0.101)|VS2022 17.4.x - 17.9.x|Tue, Nov 7, 2023|[Out of Support](https://dotnet.microsoft.com/en-us/platform/support/policy/maui ".NET MAUI Support Policy")|
|Stable|[.NET 8 SR10](https://github.com/dotnet/maui/releases/tag/8.0.100 "Changelog") (8.0.100) <br /> _Requires JDK 17 and Android SDK 34_ <br /> _Requires Apple Xcode 15.4 and Supports Apple Xcode 16_|VS2022 17.12.x|Tue, Nov 12, 2024|[Out of Support](https://dotnet.microsoft.com/en-us/platform/support/policy/maui ".NET MAUI Support Policy")|
|Stable|[.NET 9 SR8](https://github.com/dotnet/maui/releases/tag/9.0.80 "Changelog") (9.0.80) <br /> _Requires JDK 17 and Android SDK 35_ <br /> _Requires Apple Xcode 16.1_|VS2022 17.14.x|Tue, Jun 10, 2025|Active|
|Preview|[.NET 10 Preview 5](https://github.com/dotnet/maui/releases/tag/10.0.0-preview.5.25306.5 "Changelog") (10.0.0-preview.5.25306.5) <br /> _Requires JDK 17 and Android SDK 36_ <br /> _Requires Apple Xcode 16.4_|VS2022 17.14.x|Tue, Jun 10, 2025|-|

Version History and its dependencies are [here](https://aka.ms/maui/versions).

Use the below commands to verify the version installed:

```shell
dotnet --version
```
```shell
dotnet workload list
```

And to install a workload, run the following command:

On Windows, this is to be executed on an `elevated prompt`:

```shell
dotnet workload install maui
```

On macOS:

```shell
sudo dotnet workload install maui
```

On Linux (Only `Android` workload is supported for now):

```shell
sudo dotnet workload install maui-android
```

If already installed, can be updated to the latest version with the below command:

```shell
dotnet workload update
```

Templates have been updated to support .NET MAUI 8, 9, and 10 (Preview) and is available to install from.

|Channel|NuGet|VS Marketplace|
|:---:|:---:|:---:|
|Stable|[![VijayAnand.MauiTemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.MauiTemplates?icon=nuget&foo=bar)](https://www.nuget.org/packages/VijayAnand.MauiTemplates)|[![.NET MAUI Project and Item Templates - VS Marketplace](https://badgen.net/vs-marketplace/v/egvijayanand.maui-templates?icon=visualstudio&foo=bar)](https://marketplace.visualstudio.com/items?itemName=egvijayanand.maui-templates)|
<!--
|Preview|[![VijayAnand.MauiTemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.MauiTemplates/pre?icon=nuget&foo=bar)](https://www.nuget.org/packages/VijayAnand.MauiTemplates/absoluteLatest)| - |
-->

### For VS2022 users:

To provide an integrated experience, a VS extension has been developed to host these templates.

The All-in-One .NET MAUI Templates Pack VS extension (v5.12.0.0 or higher) is now supported on both **x64 and ARM64** installations of Visual Studio 2022. Happy coding!

*Consequently, the minimum supported version of Visual Studio 2022 will be v17.6 or higher.*

Extension is made available in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=egvijayanand.maui-templates ".NET MAUI Templates Pack") and even more easier, can be installed from within Visual Studio itself (Extensions -> Manage Extensions / Alt + X + M).

![Manage Extensions - Visual Studio](images/vs-manage-extensions.png)

This has Project Templates for:

* .NET MAUI App - An [All-in-One .NET MAUI App](#all-in-one-net-maui-app-project-template) Project Template - For more details, check out these [articles](https://egvijayanand.in/category/net-maui/templates-net-maui/ "All-in-One .NET MAUI App Project Template")
* [.NET MAUI Class Library](#net-maui-class-library-project-template)
* [Shared Class Library](#shared-class-library-project-template) (Xamarin.Forms and .NET MAUI)

![Create Project - Visual Studio](images/maui-project-templates.png)

And has Item Templates for:

* [Generic Item](#generic-item-templates)
* [Generic Item (C#)](#generic-item-templates)
* Content Page
* Content Page (C#)
* Content Page (Razor)
* Content Page with BlazorWebView
* Content Page with BlazorWebView (C#)
* Content Page with ViewModel
* Content Page (C#) with ViewModel
  - For both the `Page with ViewModel` templates, ensure only the real page name alone is provided as input like `Settings` as the `Page` and `ViewModel` will be suffixed to it like `SettingsPage` and `SettingsViewModel`. And Page will be generated in the `Views` folder and ViewModel will be generated in the `ViewModels` folder.
  - The ViewModels are generated with the base class titled `BaseViewModel` (implementation left to the user).
  - Recommended to add [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm), an officially supported NuGet package, to make it easy to work with MVVM design pattern.
  - This [MVVM - Made Easy](https://egvijayanand.in/category/mvvm/made-easy/) articles can help you to get started with this brand-new NuGet package.
* Content View
* Content View (C#)
* Content View (Razor)
* Resource Dictionary
* Resource Dictionary (XAML only)
* Shell Page
* Shell Page (C#)
* Custom View and Handler (Regular)
  - Handler definitions generated in the Platforms folder
* Custom View and Handler (Cond.)
  - Handler definitions generated in the same folder in conditional compilation format
* Custom View and Renderer (Regular)
  - Renderer definitions generated in the Platforms folder
* Custom View and Renderer (Cond.)
  - Renderer definitions generated in the same folder in conditional compilation format
* Comet Page (C#)
* Partial Class (C#)
  - Made available in the section titled `Code`
\
&nbsp;
* For Cond. type template to work properly, ensure Conditional Compilation is enabled (mentioned in detail [**here**](#conditional-compilation "Conditional Compilation"))

Now VS2022 extension is loaded with 25+ C# and XAML Code Snippets.

XAML Snippets for new Layouts, Gestures, Color, Style.

C# Snippets for Properties such as Attached, Bindable, ViewModel and Comet (MVU design pattern).

Types such as `record` and `record struct`.

Snippets for Method definition, Event Handler definition (async version also).

![Add New Item dialog - Visual Studio](images/add-new-item.png)

### .NET CLI Template

For making use of these templates cross-platform, have provided it as .NET CLI template package distributed via NuGet.

<!-- [![VijayAnand.MauiTemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.MauiTemplates/)](https://www.nuget.org/packages/VijayAnand.MauiTemplates/) -->

Install the template package from NuGet with the below command.

Stable:

```shell
dotnet new install VijayAnand.MauiTemplates
```

<!--
Preview:

```shell
dotnet new install VijayAnand.MauiTemplates::4.4.0-preview.5
```
-->

If you've already installed this package, then this can be updated to the latest version with the below command.

```shell
dotnet new update --check-only
```
```shell
dotnet new update
```

This comes with with the following templates:

Name | Template Name | Type
:---: | :---: | :---:
|[All-in-One .NET MAUI App](#all-in-one-net-maui-app-project-template)|mauiapp|Project|
|[.NET MAUI Class Library](#net-maui-class-library-project-template)|mauiclasslib|Project|
|[Shared Class Library](#shared-class-library-project-template)|sharedclasslib|Project|
|[.NET MAUI Item (XAML)](#generic-item-templates)|maui-item|Item|
|[.NET MAUI Item (C#)](#generic-item-templates)|maui-item-cs|Item|
|ContentPage (XAML)|maui-page|Item|
|ContentPage (C#)|maui-page-cs|Item|
|ContentPage (Razor)|maui-page-razor|Item|
|ContentView (XAML)|maui-view|Item|
|ContentView (C#)|maui-view-cs|Item|
|ContentView (Razor)|maui-view-razor|Item|
|ResourceDictionary|maui-resdict|Item|
|ShellPage (XAML)|maui-shell|Item|
|ShellPage (C#)|maui-shell-cs|Item|
|ShellPage (Razor)|maui-shell-razor|Item|
|[ContentPage with ViewModel](#page-with-viewmodel)|maui-mvvm|Item|
|[ContentPage with ViewModel (C#)](#page-with-viewmodel)|maui-mvvm-cs|Item|
|ContentPage with BlazorWebView (XAML)|maui-bwv|Item|
|ContentPage with BlazorWebView (C#)|maui-bwv-cs|Item|
|[Partial Class (C#)](#partial-class-item-template)|class-cs|Item|

![All-in-One .NET MAUI App Project Template](images/dotnetmaui-all-in-one-project-template-pinned.png)

### What's New:

Starting with [v2.0.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/2.0.0) of the template package, to effectively support .NET MAUI on both `.NET 6` and `.NET 7`, CLI project template defines a new parameter named `framework`:

And from [v3.0.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/3.0.0) of the template package, CLI project template `framework` parameter adds `.NET 8` as another option.

And from [v4.0.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/4.0.0) of the template package, CLI project template defines a new parameter named `language`:

And from [v4.4.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/4.4.0) of the template package, CLI project template defines a new parameter named `central-pkg-mgmt`:

And from [v4.5.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/4.5.0) of the template package, CLI project template defines a new parameter named `include-shared-toolkit`:

And from [v4.6.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/4.6.0) of the template package, CLI project template defines a new parameter named `nightly`:

And from [v5.0.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/5.0.0) of the template package, CLI project template `framework` parameter adds `.NET 9` as another option.

And from [v5.5.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/5.5.0) of the template package, CLI project template defines a new parameter named `maui-class-library`:

And from [v5.7.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/5.7.0) of the template package, Class Library project template support referencing the Maps package.

And from [v5.11.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/5.11.0) of the template package, support for XML-based solution file (slnx) format.

And from [v5.15.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/5.15.0) of the template package, support to add and configure the Syncfusion.Maui.Toolkit NuGet package.

And from [v6.1.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/6.1.0) of the template package, a new option has been included for the design pattern (`-dp`) parameter, named `JSHybrid`, which creates a project using `HybridWebView` with all prerequisites set automatically, requiring no manual intervention.

And from [v7.0.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/7.0.0) of the template package, CLI project template `framework` parameter adds `net10.0` as another option to support `.NET 10` Previews.

### Parameters:

* HybridWebView Project Template:

  Introduced an option to create a new project template using HybridWebView.
  
  Consult this [Exploring .NET MAUI 9 - HybridWebView](https://egvijayanand.in/2024/10/04/exploring-dotnet-maui-9-hybridwebview-features/) article to know more about it.

  To facilitate this, the design pattern (`-dp`) parameter includes a new value called `JSHybrid`, which creates an App project using `HybridWebView` with all prerequisites set automatically, requiring no manual intervention.

  In the VS2022/Rider IDE, within the Project Options page, this `Application Design` option is available as a dropdown UI control. Select `JSHybrid` as its value.

  *Since HybridWebView is a feature introduced in .NET MAUI 9, creating a .NET MAUI 8 App with the value of `JSHybrid` will NOT result in an error; instead, it will fall back by creating an App project that corresponds to the default `Plain` value from both the CLI and the IDE.*

  ```shell
  dotnet new mauiapp -o MyApp -dp JSHybrid
  ```

  *Note: The design pattern (`-dp`) parameter with the value `Hybrid` will continue to generate an App project using `BlazorWebView`, which works on both .NET MAUI 8 and 9, the present stable channel release.*

  ```shell
  dotnet new mauiapp -o BlazorApp -dp Hybrid
  ```

* [Syncfusion.Maui.Toolkit](https://www.nuget.org/packages/Syncfusion.Maui.Toolkit) NuGet Package (Short notation: `-isft`):

  Introduced the option to add and configure the Syncfusion.Maui.Toolkit NuGet package.

  *Note: This would be an explicit option*

  `-isft` | `--include-syncfusion-toolkit` - Default value is `false`

  ```shell
  dotnet new mauiapp -o MyApp -isft
  ```
  ```shell
  dotnet new mauiclasslib -o MauiLib -isft
  ```
  ```shell
  dotnet new sharedclasslib -o SharedLib -isft
  ```

* SLNX Solution File Format (Short notation: `-slnx`):

  Introduces support for the new, simplified, and easily understandable XML-based solution file format.

  *This would be an explicit option since the SLNX feature is currently in the preview stage and is only supported on VS2022.*

  `-slnx` | `--use-slnx` - Default value is `false`

  ```shell
  dotnet new mauiapp -o MyApp -slnx
  ```

* MAUI Class Library (Short notation: `-mcl`):

  Option to abstract the Shared components as a separate .NET MAUI Class Library.

  This will create a solution structure that is akin to Xamarin.Forms (the only difference is that there won't be multiple head projects).

  `-mcl` | `--maui-class-library` - Default value is `false`

  ```shell
  dotnet new mauiapp -o MyApp -mcl
  ```

  This abstracts both MAUI components and Razor components in an Hybrid style App:

  ```shell
  dotnet new mauiapp -o HybridApp -dp Hybrid -mcl -rcl
  ```

* Nightly build: (Short notation: `-ni`):

  Option to reference Nightly build MAUI packages (from the [CI feed](https://dev.azure.com/xamarin/public/_artifacts/feed/maui-nightly "CI Feed")) in all the supported templates.

  `-ni` | `--nightly` This is a Boolean parameter - Default value is `false`. _Can also be used with the CPM option too_.

  Update: When creating MAUI projects with Nightly build opted-in with template v5.6.0 or later, the CI package source configuration process is automated with a local NuGet.config file. So, no need for any manual steps. _Only required when earlier templates version is used._
  
  Note: For this work, add the following URL as a NuGet package source (make use of the command) and more details [here](https://github.com/dotnet/maui/wiki/Nightly-Builds "Nightly Builds"):

  *.NET MAUI getting released as NuGet packages is supported only from .NET 8. So, this nightly build option won't work with .NET 7 and earlier.*


  ```shell
  dotnet nuget add source -n maui-nightly https://aka.ms/maui-nightly/index.json
  ```

  Examples:

  ```shell
  dotnet new mauiapp -o MyApp -ni
  ```

  ```shell
  dotnet new mauiclasslib -o MauiLib -ni
  ```

  ```shell
  dotnet new sharedclasslib -o SharedLib -ni
  ```

* Central Package Management: (Short notation: `-cpm`):

  This is a Boolean parameter and its default value is `false`.

  Examples:

  ```shell
  dotnet new mauiapp -o MyApp -cpm
  ```

  ```shell
  dotnet new mauiclasslib -o MauiLib -cpm
  ```

  ```shell
  dotnet new sharedclasslib -o SharedLib -cpm
  ```

* Language: (Short notation: `-lang`):

  This can take `C#` / `F#` as its options (with `C#` being the default value, if not specified).

  Examples:

  ```shell
  dotnet new mauiapp -lang F#
  ```

  For creating a .NET MAUI App on .NET 9:

  ```shell
  dotnet new mauiapp -lang F#
  ```

* Framework: (Short notation: `-f`)

  This can take `net8.0` / `net9.0` / `net10.0` as its options (with `net9.0` being the default value, if not specified).

  Examples:

  For creating a .NET MAUI 9 App:
  
  Below command can be simplified to `dotnet new mauiapp` as default value of `framework` parameter is `net9.0`

  ```shell
  dotnet new mauiapp -f net9.0
  ```

  For creating a .NET MAUI 8 App:

  _Explicit value for the `framework` parameter is required._

  ```shell
  dotnet new mauiapp -f net8.0
  ```

  For creating a .NET MAUI 10 App:

  _Explicit value for the `framework` parameter is required._

  ```shell
  dotnet new mauiapp -f net10.0
  ```

In .NET CLI, all of these _Items Template_ require a mandatory parameter:

* Name: (Short notation: `-n`)

    The name of the Item/Page/View to create. _For Pages/Views, don't need to suffix it with the name like .xaml_, it will get added.

    _If the name parameter is not specified, by default, the **.NET CLI template engine will take the current folder name as the filename** (current behaviour of the templating engine)._

<!--
* Namespace: (Short notation: `-na`)

    The namespace for the generated files.

    *While working with .NET 7 SDK or later, the namespace parameter in short notation needs to be passed as `-p:na` (i.e., it needs to be prefixed with `-p:`).*
-->

* Now with more options while creating the app or class library project, ability to include NuGet packages on the fly for `CommunityToolkit.Maui`, `CommunityToolkit.Maui.Markup`, `CommunityToolkit.Mvvm` or all.

*Note: Parameter values are case-insensitive.*

Both .NET MAUI *App* and *Class Library* templates take the below optional Boolean parameters to include the officially supported `CommunityToolkit` NuGet packages:

*Specifying the parameter name, either in short or full notation, implies that it is defined.*

* `-it` | `--include-toolkit` - Default is `false`
* `-im` | `--include-markup` - Default is `false`
* `-imt` | `--include-mvvm-toolkit` - Default is `false`

Other Parameters:

* `-isft` | `--include-syncfusion-toolkit` - Default is `false`
* `-ist` | `--include-shared-toolkit` - Default is `false`
* `-cc` | `--conditional-compilation` - Default is `false`

### Conditional Compilation

And now conditional compilation can be configured so that platform source files can be defined anywhere in the project provided they follow a naming convention as mentioned below. This will allow maintaining related source files in the same place, especially MAUI Handlers.

* \*.Standard.cs - Files targeting the BCL
* \*.Android.cs - Files specific to Android
* \*.iOS.cs - Files shared with both iOS and MacCatalyst
* \*.MacCatalyst.cs - Files specific to MacCatalyst
* \*.Tizen.cs - Files specific to Tizen
* \*.Windows.cs - Files specific to Windows

For existing projects, add the below block of code in the project file (.csproj). _This will modify the behavior of build process so due care must be taken if doing so._

```xml
<ItemGroup Condition="'$(TargetFramework)' != 'net9.0'">
    <Compile Remove="**\*.Standard.cs" />
    <None Include="**\*.Standard.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
</ItemGroup>

<ItemGroup Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) != 'ios' AND $([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) != 'maccatalyst'">
    <Compile Remove="**\*.iOS.cs" />
    <None Include="**\*.iOS.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
    <Compile Remove="**\iOS\**\*.cs" />
    <None Include="**\iOS\**\*.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
</ItemGroup>

<ItemGroup Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) != 'android'">
    <Compile Remove="**\*.Android.cs" />
    <None Include="**\*.Android.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
    <Compile Remove="**\Android\**\*.cs" />
    <None Include="**\Android\**\*.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
</ItemGroup>

<ItemGroup Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) != 'maccatalyst'">
    <Compile Remove="**\*.MacCatalyst.cs" />
    <None Include="**\*.MacCatalyst.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
    <Compile Remove="**\MacCatalyst\**\*.cs" />
    <None Include="**\MacCatalyst\**\*.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
</ItemGroup>

<ItemGroup Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) != 'tizen'">
    <Compile Remove="**\*.Tizen.cs" />
    <None Include="**\*.Tizen.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
    <Compile Remove="**\Tizen\**\*.cs" />
    <None Include="**\Tizen\**\*.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
</ItemGroup>

<ItemGroup Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) != 'windows'">
    <Compile Remove="**\*.Windows.cs" />
    <None Include="**\*.Windows.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
    <Compile Remove="**\Windows\**\*.cs" />
    <None Include="**\Windows\**\*.cs" Exclude="$(DefaultItemExcludes);$(DefaultExcludesInProjectFolder)" />
</ItemGroup>
```

### All-in-One .NET MAUI **App** Project Template:

This takes two additional parameters to define the application design pattern and target platform respectively. Not all options are supported in the F# template. For now, only Plain and Hybrid option is available.

* `-dp` | `--design-pattern`

Can take any one of the following values, with default value set to `Plain`:

|Parameter Value|Description|
|:---:|:---|
|Plain|App configured to work with a single, initial screen.|
|Hierarchical|App configured to work in a Hierarchical pattern using `NavigationPage`.|
|Tab|App configured to work in a Tabbed fashion using `TabbedPage`.|
|Shell|App configured to work with Routes using `Shell` page.|
|Hybrid|App configured to work in a `Blazor Hybrid` mode using `BlazorWebView`.|
|JSHybrid|App configured to work in a `JavaScript Hybrid` mode using `HybridWebView` (.NET MAUI 9 or later).|
|Markup|App configured to work with `C# Markup` syntax.|
|Razor|App configured to work with `Razor` syntax.|
|Reactor|App configured to work with MVU pattern using `Reactor`.|

* `-tp` | `--target-platform`

Can take a combination of the following values, with default value set to `All`:

|Parameter Value|Description|
|:---:|:---|
|All|Targets all possible .NET MAUI supported platforms.|
|Base|Base framework (.NET 8/9/10) based on the `framework` opted.|
|Android|Targets Android platform.|
|iOS|Targets iOS platform.|
|macOS|Targets macOS platform via Mac Catalyst.|
|Windows|Targets Windows platform.|
|Tizen|Targets Tizen platform.|
|Mobile|Targets Android and iOS platforms.|
|Desktop|Targets Windows and macOS platforms.|
|Apple|Targets iOS and macOS platforms.|

![Target Platform Options - Visual Studio](images/dotnetmaui-all-in-one-app-project-options.png)

Additional parameters supported:

MVVM is a delightful and development-friendly design pattern to work with. To support this, a new parameter has been introduced:

* `-mvvm` | `--use-mvvm` - Default is `false`
* `-icb` | `--include-compiled-bindings` - Default is `false`

*Note: Opting for this MVVM option will not have any impact on the App created with Web-based Razor syntax or MVU based Comet/Reactor.*

While creating an App (C#), an option to abstract the Shared components as a separate .NET MAUI Class Library.

* `-mcl` | `--maui-class-library` - Default is `false`

While creating a Blazor Hybrid App, an option to abstract the Razor components as a separate Razor Class Library.

* `-rcl` | `--razor-class-library` - Default is `false`

The target for the Windows platform can be either `Package` (MSIX) or `Unpackaged`. By default, it is set as `Package`, this can be overridden while creating the project by including the below parameter:

* `-wu` | `--windows-unpackaged` - Default is `false`

Further options to add and configure [CommunityToolkit.Maui.Camera](https://www.nuget.org/packages/CommunityToolkit.Maui.Camera), [Microsoft.Maui.Controls.Foldable](https://www.nuget.org/packages/Microsoft.Maui.Controls.Foldable), [CommunityToolkit.Maui.MediaElement](https://www.nuget.org/packages/CommunityToolkit.Maui.MediaElement), [Microsoft.Maui.Controls.Maps](https://www.nuget.org/packages/Microsoft.Maui.Controls.Maps), or all NuGet packages.

* `-ic` | `--include-camera` - Default is `false`
* `-if` | `--include-foldable` - Default is `false`
* `-ime` | `--include-media-element` - Default is `false`
* `-inm` | `--include-maps` - Default is `false`

<!--
*Note: If the project target `.NET 6`, selecting the MediaElement/Foldable/Maps option will NOT have any impact.*
-->

Examples:

```shell
dotnet new mauiapp -dp Shell -tp Android
```

```shell
dotnet new mauiapp -dp Hybrid --tp Mobile
```

### .NET MAUI Class Library Project Template:

Similar to All-in-One .NET MAUI App, the Class Library project template also takes `target-platform` as a parameter that takes a combination from the same set of values (with `All` being the default value).

* Can be created targeting .NET Razor SDK
  - Parameter name: `--use-razor-sdk` | `-urs`
* Can be created targeting .NET MAUI Core
  - Parameter name: `--use-maui-core` | `-umc`
* Can be created targeting .NET MAUI Essentials
  - Parameter name: `--use-maui-essentials` | `-ume`

![Class Library Project Options - Visual Studio](images/dotnetmaui-class-library-project-options.png)

### Shared Class Library Project Template:

The Target Framework of Xamarin.Forms library can be defined with the the below parameter.

* `-xf` | `--xamarin-forms` 

Supported values are:

* `netstandard2.0` (Default, if not specified)
* `netstandard2.1`

*Define the Target Framework of .NET MAUI library with the `-f` | `--framework` parameter.*

This takes the below optional Boolean parameters to include the officially supported NuGet packages:

*Specifying the parameter name, either in short or full notation, implies that it is defined.*

Single parameter to include commonly used NuGet packages (`Maps`, `Syncfusion Toolkit`, and `Essential Interfaces` are explicit):

* `-asp` | `--all-supported-packages` - Default is `false`

Specific to `Xamarin.Forms`:

* `-ife` | `--include-forms-essentials` - Default is `false`
* `-ifei` | `--include-forms-essentials-interfaces` - Default is `false`
* `-ift` | `--include-forms-toolkit` - Default is `false`
* `-ifm` | `--include-forms-markup` - Default is `false`
* `-infm` | `--include-forms-maps` - Default is `false`

Specific to `.NET MAUI`:

* `-imt` | `--include-maui-toolkit` - Default is `false`
* `-isft` | `--include-syncfusion-toolkit` - Default is `false`
* `-imm` | `--include-maui-markup` - Default is `false`
* `-inmm` | `--include-maui-maps` - Default is `false`

Common to both:

* `-inmt` | `--include-mvvm-toolkit` - Default is `false`
* `-ist` | `--include-shared-toolkit` - Default is `false`

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

### Partial Class Item Template:

This item template (short name: `class-cs`) allows to create a C# class from CLI with support for multiple options.

|Parameter Name|Type|Default Value|Remarks|
|:--:|:---:|:---:|:---|
access-modifier|choice|public|Specifies the accessibility of the class type.|
base|text|object|Specifies the base type for the class.|
abstract|bool|false|Option to create the type as abstract.|
partial|bool|true|Option to create the type as partial.|
sealed|bool|false|Option to create the type as sealed.|
static|bool|false|Option to create the type as static.|

Access Modifier parameter (`--access-modifier` | `-am`):

Supported values are:

* public (default value, if not provided)
* internal
* protected
* private

File-scoped Namespace parameter (`-fsn` | `--file-scoped-namespace`), the default value is `false`.

### Usage:

After installation, use the below command(s) to create new artifacts using the template (both provide the same output):

With parameter names abbreviated:

.NET MAUI App:

```shell
dotnet new mauiapp -n MyApp -dp Shell
```
```shell
dotnet new mauiapp -n MyApp -dp Hybrid
```
```shell
dotnet new mauiapp -n MyApp -dp JSHybrid
```
```shell
dotnet new mauiapp -n MyApp -dp Markup
```
```shell
dotnet new mauiapp -n MyApp -dp Razor
```
```shell
dotnet new mauiapp -n MyApp -dp Reactor
```

Option to use MVVM:

```shell
dotnet new mauiapp -n MyApp -mvvm
```
```shell
dotnet new mauiapp -n MyApp -dp Markup -mvvm
```

Option to use MVVM (Compiled Bindings):

```shell
dotnet new mauiapp -n MyApp -mvvm -icb
```

Option to create Razor class library while creating Blazor Hybrid App:

```shell
dotnet new mauiapp -n MyApp -dp Hybrid -rcl
```

Option to include NuGet packages:

```shell
dotnet new mauiapp -n MyApp -dp Shell -it -im -imt -ime -inm -if
```

Option to configure Conditional Compilation:

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

Option to configure Conditional Compilation:

```shell
dotnet new mauiclasslib -n MyApp.Core -cc
```

Shared Class Library:

```shell
dotnet new sharedclasslib -n MyApp.UI
```
Option to include commonly used NuGet packages:

```shell
dotnet new sharedclasslib -n MyApp.UI -asp
```

### Generic Item Templates:

* An innovative generic template, in XAML and C#, for creating items of any type
* Supported both within the VS2022 IDE and CLI
  - Covered in detail in the below articles
  - [Introducing .NET MAUI Generic Item Templates](https://egvijayanand.in/2024/01/16/introducing-dotnet-maui-generic-item-templates/)
  - [Introducing .NET MAUI Generic Item Templates for Visual Studio 2022](https://egvijayanand.in/2024/01/23/introducing-dotnet-maui-generic-item-templates-for-visual-studio-2022/)
* On CLI, it is named as `maui-item` and `maui-item-cs`
* The same set of parameters is defined in the UI as `dropdown`, `textbox` and `checkbox` for ease of use
* Both needs one required parameter, `-b` / `--base`, the base type
* And optionally takes another parameter, `-g` / `--generic`, to specify the generic base type
* In addition, the XAML template takes one more parameter, `-xo` / `--xaml-only`, to generate only the XAML definition
* Frequently used base types are loaded in the Editable dropdown, user can also enter their value here
* Ensure the values are entered in Pascal notation. XAML templates support XML namespace prefix, quite like how it is used in real world (`mct:Popup`)
* The one big advantage of using this on IDE is the relative namespace to the folder where the item is created whereas on CLI, this defaults to the root namespace. As relative namespace resolution is yet to be fully supported by the CLI templating engine and is actively tracked [here](https://github.com/dotnet/templating/issues/6010)

![.NET MAUI All-in-One Generic Item Template](images/dotnetmaui-generic-item-popup.png)

*Note: Namespace resolution in both XAML and C# files is left to the user, as deriving them with the template is outside its scope.*

*Tip: For the XAML template, pass the `xmlns` scope as part of the input parameter value and it'll be used appropriately in the generated source files.*

*Tip: Use `local` scope to refer to the files in the same directory like `Views`. For example, `local:BasePage`*

CLI Commands:

 ```shell
dotnet new maui-item -n LoginPage -b ContentPage
```
```shell
dotnet new maui-item-cs -n ProductView -b ContentView
```
```shell
dotnet new maui-item -n CartPage -b MauiPage -g CartViewModel
```

*For Page/Shell/View Item templates, DON'T suffix anything to the name, it'll be included automatically.*

Pages:
```shell
dotnet new maui-page -n Home
```
```shell
dotnet new maui-page-cs -n Home
```
```shell
dotnet new maui-page-razor -n Home
```

### Page with ViewModel:

```shell
dotnet new maui-mvvm -n Login
```
```shell
dotnet new maui-mvvm-cs -n Login
```

ContentPage with BlazorWebView:

```shell
dotnet new maui-bwv -n Home
```
```shell
dotnet new maui-bwv-cs -n Home
```

Views:

```shell
dotnet new maui-view -n Order
```
```shell
dotnet new maui-view-cs -n Order
```
```shell
dotnet new maui-view-razor -n Order
```

Shell:

```shell
dotnet new maui-shell -n App
```
```shell
dotnet new maui-shell-cs -n App
```
```shell
dotnet new maui-shell-razor -n App
```

Resource Dictionary:

```shell
dotnet new maui-resdict -n DarkTheme
```
```shell
dotnet new maui-resdict -n LightTheme -xo
```

Partial Class:

```shell
dotnet new class-cs -n BaseViewModel
```
```shell
dotnet new class-cs -n BaseViewModel -fsn
```
```shell
dotnet new class-cs -n OrderDataStore -b IDataStore -p false -am internal
```

With parameter names expanded:

.NET MAUI App:

```shell
dotnet new mauiapp --name MyApp --design-pattern Shell
```
```shell
dotnet new mauiapp --name MyApp --design-pattern Hybrid
```
```shell
dotnet new mauiapp --name MyApp --design-pattern JSHybrid
```
```shell
dotnet new mauiapp --name MyApp --design-pattern Markup
```
```shell
dotnet new mauiapp --name MyApp --design-pattern Razor
```
```shell
dotnet new mauiapp --name MyApp --design-pattern Reactor
```

Option to use MVVM:

```shell
dotnet new mauiapp --name MyApp --use-mvvm
```
```shell
dotnet new mauiapp --name MyApp --design-pattern Markup --use-mvvm
```

Option to use MVVM (Compiled Bindings):

```shell
dotnet new mauiapp --name MyApp --use-mvvm --include-compiled-bindings
```

Option to create Razor class library while creating Blazor Hybrid App:

```shell
dotnet new mauiapp --name MyApp --design-pattern Hybrid --razor-class-library
```

Option to include NuGet packages:

```shell
dotnet new mauiapp --name MyApp --design-pattern Shell --include-toolkit --include-markup --include-mvvm-toolkit --include-media-element --include-maps --include-foldable
```
```shell
dotnet new mauiapp --name MyApp --design-pattern Shell --conditional-compilation
```

.NET MAUI Class Library:

```shell
dotnet new mauiclasslib --name MyApp.Core
```
```shell
dotnet new mauiclasslib --name MyApp.Core --include-toolkit --include-markup --include-mvvm-toolkit
```
```shell
dotnet new mauiclasslib --name MyApp.Core --conditional-compilation
```

Shared Class Library:

```shell
dotnet new sharedclasslib --name MyApp.UI
```
```shell
dotnet new sharedclasslib --name MyApp.UI --all-supported-packages
```

Generic Item Templates:

 ```shell
dotnet new maui-item --name LoginPage --base ContentPage
```
```shell
dotnet new maui-item-cs --name ProductView --base ContentView
```
```shell
dotnet new maui-item --name CartPage --base MauiPage --generic CartViewModel
```

*For Page/Shell/View Item templates, don't suffix anything to the name, it'll be included automatically.*

Pages:

```shell
dotnet new maui-page --name Home
```
```shell
dotnet new maui-page-cs --name Home
```
```shell
dotnet new maui-page-razor --name Home
```

Page with ViewModel:

```shell
dotnet new maui-mvvm --name Login
```
```shell
dotnet new maui-mvvm-cs --name Login
```

ContentPage with BlazorWebView:


```shell
dotnet new maui-bwv --name Home
```
```shell
dotnet new maui-bwv-cs --name Home
```

Views:

```shell
dotnet new maui-view --name Order
```
```shell
dotnet new maui-view-cs --name Order
```
```shell
dotnet new maui-view-razor --name Order
```

Shell:

```shell
dotnet new maui-shell --name App
```
```shell
dotnet new maui-shell-cs --name App
```
```shell
dotnet new maui-shell-razor --name App
```

Resource Dictionary:

```shell
dotnet new maui-resdict --name DarkTheme
```
```shell
dotnet new maui-resdict --name LightTheme --xaml-only
```

Partial Class:

```shell
dotnet new class-cs --name BaseViewModel
```
```shell
dotnet new class-cs --name BaseViewModel --file-scoped-namespace
```
```shell
dotnet new class-cs --name OrderDataStore --base IDataStore --partial false --access-modifier internal
```
<!--
### For VS2019 users:

Now, ContentPage is completely moved into .NET MAUI world with a brand new xml namespace and using directive.

So that the existing Xamarin.Forms item templates cannot be used as is from now on and modifying it every time is painful.

Hence have created a VS extension exclusively to be used with .NET MAUI projects.

Grab these templates from the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=egvijayanand.maui-item-templates) and even more easier, can be installed from within Visual Studio itself (Extensions -> Manage Extensions / Alt + X + M)

This has a Project Template for:

* .NET MAUI Class Library (Preview 10)

And has Item Templates for:

* Content Page (.NET MAUI)
* Content Page (C#) (.NET MAUI)
* Content View (.NET MAUI)
* Content View (C#) (.NET MAUI)
* Resource Dictionary (.NET MAUI)
* Shell Page (.NET MAUI)

![Add New Item dialog - Visual Studio](images/add-new-item.png)
-->
