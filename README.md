## .NET MAUI Project and Item Templates
This repository is to host the .NET MAUI Project Templates, Item Templates and Code Snippets.

Join me on [**Developer Thoughts**](https://egvijayanand.in/ "Developer Thoughts"), an exclusive blog for .NET MAUI and Blazor, for articles on working with these templates and much more.

We all know that .NET MAUI is an evolution of Xamarin.Forms.

Release Details:

|Channel|.NET MAUI Version|IDE Version|Release Date|
|:---:|:---:|:---:|:---:|
|Stable|.NET 6 SR10 (6.0.552)|VS2022 17.5.0|Tue, Jan 31, 2023|
|Stable|.NET 7 SR3 (7.0.59)|VS2022 17.5.0|Tue, Jan 31, 2023|
|Preview|.NET 8 Preview 1 (8.0.0-preview.1.7762)|VS2022 17.6.0 Preview 1.0|Tue, Feb 21, 2023|

Use the below commands to verify the version installed:

```shell
dotnet --version
```
```shell
dotnet workload list
```

Templates have been updated to support .NET 6/7/8 and is available to install from.

|Channel|NuGet|VS Marketplace|
|:---:|:---:|:---:|
|Stable|[![VijayAnand.MauiTemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.MauiTemplates/?icon=nuget)](https://www.nuget.org/packages/VijayAnand.MauiTemplates/)|[![.NET MAUI Project and Item Templates - VS Marketplace](https://badgen.net/vs-marketplace/v/egvijayanand.maui-templates?icon=visualstudio)](https://marketplace.visualstudio.com/items?itemName=egvijayanand.maui-templates)|
|Preview|[![VijayAnand.MauiTemplates - NuGet Package](https://badgen.net/nuget/v/VijayAnand.MauiTemplates/latest?icon=nuget)](https://www.nuget.org/packages/VijayAnand.MauiTemplates/absoluteLatest)| - |

### For VS2022 users:

To provide an integrated experience, a VS extension has been developed to host these templates.

Extension is made available in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=egvijayanand.maui-templates ".NET MAUI Templates Pack") and even more easier, can be installed from within Visual Studio itself (Extensions -> Manage Extensions / Alt + X + M).

![Manage Extensions - Visual Studio](images/vs-manage-extensions.png)

This has Project Templates for:

* .NET MAUI App - An All-in-One .NET MAUI App Project Template - For more details, check out this [article](https://egvijayanand.in/all-in-one-dotnet-maui-app-project-template/ "All-in-One .NET MAUI App Project Template")
* .NET MAUI App (C#)
* .NET MAUI Class Library
* Shared Class Library (Xamarin.Forms and .NET MAUI)

![Create Project - Visual Studio](images/maui-project-templates.png)

And has Item Templates for:

* Content Page (.NET MAUI)
* Content Page (C#) (.NET MAUI)
* Content Page with ViewModel (.NET MAUI)
* Content Page (C#) with ViewModel (.NET MAUI)
  - For both the `Page with ViewModel` templates, ensure only the real page name alone is provided as input like `Settings` as the `Page` and `ViewModel` will be suffixed to it like `SettingsPage` and `SettingsViewModel`. And Page will be generated in the `Views` folder and ViewModel will be generated in the `ViewModels` folder.
  - The ViewModels are generated with the base class titled `BaseViewModel` (implementation left to the user).
  - Recommended to add [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm), an officially supported NuGet package, to make it easy to work with MVVM design pattern.
  - This MVVM - Made Easy [Part 1](https://egvijayanand.in/2022/04/22/mvvm-made-easy/) and [Part 2](https://egvijayanand.in/2022/05/09/mvvm-made-easy-with-microsoft-mvvm-toolkit-part-2/) articles can help you to get started with this brand-new NuGet package.
* Content View (.NET MAUI)
* Content View (C#) (.NET MAUI)
* Resource Dictionary (.NET MAUI)
* Resource Dictionary (XAML only)(.NET MAUI)
* Shell Page (.NET MAUI)
* Custom View and Handler (Regular) (.NET MAUI)
  - Handler definitions generated in the Platforms folder
* Custom View and Handler (Cond.) (.NET MAUI)
  - Handler definitions generated in the same folder in conditional compilation format
* Custom View and Renderer (Regular) (.NET MAUI)
  - Renderer definitions generated in the Platforms folder
* Custom View and Renderer (Cond.) (.NET MAUI)
  - Renderer definitions generated in the same folder in conditional compilation format
* Partial Class (C#)
  - Made available in the section titled `Code`
\
&nbsp;
* For Cond. type template to work properly, ensure Conditional Compilation is enabled (mentioned in detail [**here**](https://github.com/egvijayanand/dotnet-maui-templates#conditional-compilation "Conditional Compilation"))

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

```shell
dotnet new install VijayAnand.MauiTemplates
```

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
[All-in-One .NET MAUI App](#all-in-one-net-maui-app-project-template) | mauiapp | Project
[.NET MAUI Class Library](#net-maui-class-library-template) | mauiclasslib | Project
[Shared Class Library](#shared-class-library-template) | sharedclasslib | Project
ContentPage (XAML) | maui-page | Item
ContentPage (C#) | maui-page-cs | Item
ContentPage (Razor) | maui-page-razor | Item
ContentView (XAML) | maui-view | Item
ContentView (C#) | maui-view-cs | Item
ContentView (Razor) | maui-view-razor | Item
ResourceDictionary | maui-resdict | Item
ShellPage (XAML) | maui-shell | Item
ShellPage (C#) | maui-shell-cs | Item
ShellPage (Razor) | maui-shell-razor | Item
[Partial Class (C#)](#partial-class-item-template) | class-cs | Item

![All-in-One .NET MAUI App Project Template](images/dotnetmaui-all-in-one-project-template-pinned.png)

#### Parameters:

Starting with [v2.0.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/2.0.0) of the template package, to effectively support .NET MAUI on both `.NET 6` and `.NET 7`, CLI project template defines a new parameter named `framework`:

And from [v3.0.0](https://www.nuget.org/packages/VijayAnand.MauiTemplates/3.0.0) of the template package, CLI project template `framework` parameter adds `.NET 8` as another option.

* Framework: (Short notation: `-f`)

  This can take `net6.0` / `net7.0` / `net8.0` as its options (with `net7.0` being the default value, if not specified).

  Examples:

  ```shell
  dotnet new mauiapp -f net6.0
  ```

  Below command can be simplified to `dotnet new mauiapp` as default value of `framework` parameter is `net7.0`

  ```shell
  dotnet new mauiapp -f net7.0
  ```

  For creating a .NET MAUI App on .NET 8 Preview

  ```shell
  dotnet new mauiapp -f net8.0
  ```

In .NET CLI, all of these _Item Templates_ takes two parameters:

* Name: (Short notation: `-n`)

    The name of the project/page/view to create. _For pages/views, don't need to suffix it with .xaml_, it will get added.

    _If the name parameter is not specified, by default, the **.NET CLI template engine will take the current folder name as the filename** (current behaviour of the templating engine)._

* Namespace: (Short notation: `-na`)

    The namespace for the generated files.

    *While working with .NET 7 SDK or later, the namespace parameter in short notation needs to be passed as `-p:na` (i.e., it needs to be prefixed with `-p:`).*

* Now with more options while creating the app or class library project, ability to include NuGet packages on the fly for `CommunityToolkit.Maui`, `CommunityToolkit.Maui.Markup`, `CommunityToolkit.Mvvm` or all.

*Note: Parameter values are case-insensitive.*

Both .NET MAUI *App* and *Class Library* templates take the below optional Boolean parameters to include the officially supported CommunityToolkit NuGet packages:

*Specifying the parameter name, either in short or full notation, implies that it is defined.*

* `-it` | `--include-toolkit` - Default is `false`
* `-im` | `--include-markup` - Default is `false`
* `-imt` | `--include-mvvm-toolkit` - Default is `false`
* `-cc` | `--conditional-compilation` - Default is `false`

#### Conditional Compilation

And now conditional compilation can be configured so that platform source files can be defined anywhere in the project provided they follow a naming convention as mentioned below. This will allow maintaining related source files in the same place, especially MAUI Handlers.

* \*.Standard.cs - Files targeting the BCL
* \*.Android.cs - Files specific to Android
* \*.iOS.cs - Files shared with both iOS and MacCatalyst
* \*.MacCatalyst.cs - Files specific to MacCatalyst
* \*.Tizen.cs - Files specific to Tizen
* \*.Windows.cs - Files specific to Windows

For existing projects, add the below block of code in the project file (.csproj). _This will modify the behavior of build process so due care must be taken if doing so._

```xml
<ItemGroup Condition="'$(TargetFramework)' != 'net6.0'">
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

#### All-in-One .NET MAUI **App** Project Template:

This takes two additional parameters to define the application design pattern and target platform respectively:

* `-dp` | `--design-pattern`

Can take any one of the following values, with default value set to `Plain`:

|Parameter Value|Description|
|:---:|:---|
|Plain|App configured to work with a single, initial screen.|
|Hierarchical|App configured to work in a Hierarchical pattern using NavigationPage.|
|Tab|App configured to work in a Tabbed fashion using TabbedPage.|
|Shell|App configured to work with Routes using Shell page.|
|Hybrid|App configured to work in a Hybrid fashion using BlazorWebView.|
|Markup|App configured to work with C# Markup syntax.|
|Razor|App configured to work with Razor syntax.|
|Comet|App configured to work with MVU pattern using Comet.|

* `-tp` | `--target-platform`

Can take a combination of the following values, with default value set to `All`:

|Parameter Value|Description|
|:---:|:---|
|All|Targets all possible .NET MAUI supported platforms.|
|Base|Base framework (.NET 6/7/8) based on the framework opted.|
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

*Note: Opting for this MVVM option will not have any impact on the App created with Web-based Razor syntax or MVU based Comet.*

The target for the Windows platform can be either `Package` (MSIX) or `Unpackaged`. By default, it is set as `Package`, this can be overridden while creating the project by including the below parameter:

* `-wu` | `--windows-unpackaged` - Default is `false`

While targeting `.NET 7` or later, an option to add and configure `CommunityToolkit.Maui.MediaElement`, `Microsoft.Maui.Controls.Foldable`, `Microsoft.Maui.Controls.Maps`, or all NuGet packages.

* `-ime` | `--include-media-element` - Default is `false`
* `-if` | `--include-foldable` - Default is `false`
* `-inm` | `--include-maps` - Default is `false`

*Note: If the project target `.NET 6`, selecting the MediaElement/Foldable/Maps option will NOT have any impact.*

Examples (passing one or more values):

```shell
dotnet new mauiapp --design-pattern Hybrid --target-platform Mobile
```

  ```shell
dotnet new mauiapp -dp Shell -tp Android iOS Windows
```

#### .NET MAUI Class Library Template:

Similar to All-in-One .NET MAUI App, the Class Library project template also takes `target-platform` as a parameter that takes a combination from the same set of values (with `All` being the default value).

* Can be created targeting .NET Razor SDK
  - Parameter name: `--use-razor-sdk` | `-usr`
* Can be created targeting .NET MAUI Core
  - Parameter name: `--use-maui-core` | `-umc`
* Can be created targeting .NET MAUI Essentials
  - Parameter name: `--use-maui-essentials` | `-ume`

![Class Library Project Options - Visual Studio](images/dotnetmaui-class-library-project-options.png)

#### Shared Class Library Template:

This takes the below optional Boolean parameters to include the officially supported NuGet packages:

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

#### Partial Class Item Template:

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

#### Usage:

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
dotnet new mauiapp -n MyApp -dp Markup
```
```shell
dotnet new mauiapp -n MyApp -dp Razor
```
```shell
dotnet new mauiapp -n MyApp -dp Comet
```
Option to use MVVM:
```shell
dotnet new mauiapp -n MyApp -mvvm
```
```shell
dotnet new mauiapp -n MyApp -dp Markup -mvvm
```
Option to include NuGet packages:
```shell
dotnet new mauiapp -n MyApp -dp Shell -it -im -imt -ime -inm -if
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
```shell
dotnet new maui-page-razor -n HomePage
```

Views:
```shell
dotnet new maui-view -n CardView -na MyApp.Views
```
```shell
dotnet new maui-view-cs -n OrderView -na MyApp.Views
```
```shell
dotnet new maui-view-razor -n OrderView
```

Shell:
```shell
dotnet new maui-shell -n AppShell -na MyApp
```
```shell
dotnet new maui-shell-cs -n AppShell -na MyApp
```
```shell
dotnet new maui-shell-razor -n AppShell
```

Resource Dictionary:
```shell
dotnet new maui-resdict -n LightTheme -na MyApp.Themes
```

Partial Class:
```shell
dotnet new class-cs -n BaseViewModel
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
dotnet new mauiapp --name MyApp --design-pattern Markup
```
```shell
dotnet new mauiapp --name MyApp --design-pattern Razor
```
```shell
dotnet new mauiapp --name MyApp --design-pattern Comet
```
Option to use MVVM:
```shell
dotnet new mauiapp --name MyApp --use-mvvm
```
```shell
dotnet new mauiapp --name MyApp --design-pattern Markup --use-mvvm
```
Option to include NuGet packages:
```shell
dotnet new mauiapp --name MyApp --design-pattern Shell --include-toolkit --include-markup --include-mvvm-toolkit --include-media-element --include-maps --include-foldable
```
```shell
dotnet new mauiapp -n MyApp --design-pattern Shell --conditional-compilation
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

Pages:
```shell
dotnet new maui-page --name LoginPage --namespace MyApp.Views
```
```shell
dotnet new maui-page-cs --name HomePage --namespace MyApp.Views
```
```shell
dotnet new maui-page-razor --name HomePage
```

Views:
```shell
dotnet new maui-view --name CardView --namespace MyApp.Views
```
```shell
dotnet new maui-view-cs --name OrderView --namespace MyApp.Views
```
```shell
dotnet new maui-view-razor --name OrderView
```

Shell:
```shell
dotnet new maui-shell --name AppShell --namespace MyApp
```
```shell
dotnet new maui-shell-cs --name AppShell --namespace MyApp
```
```shell
dotnet new maui-shell-razor --name AppShell
```

Resource Dictionary:
```shell
dotnet new maui-resdict --name LightTheme --namespace MyApp.Themes
```

Partial Class:
```shell
dotnet new class-cs --name BaseViewModel
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
