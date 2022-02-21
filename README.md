## .NET MAUI Project and Item Templates
This repository is to host the .NET MAUI Project Templates, Item Templates and Code Snippets.

We all know that .NET MAUI is an evolution of Xamarin.Forms.

And now, .NET MAUI Preview 13 released on 15 Feb 2022 along with VS2022 Version 17.2.0 Preview 1.0

Templates have been updated to support the latest release.

### For VS2022 users:

To provide an integrated experience, a VS extension has been developed to host these templates.

Extension is made available in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=egvijayanand.maui-templates) and even more easier, can be installed from within Visual Studio itself (Extensions -> Manage Extensions / Alt + X + M).

![Manage Extensions - Visual Studio](images/vs-manage-extensions.png)

This has Project Templates for:

* .NET MAUI App (Preview 13) - An All-in-One .NET MAUI App Project Template - For more details, check out this [article](https://egvijayanand.in/all-in-one-dotnet-maui-app-project-template/)
* .NET MAUI App (C#) (Preview 13)
* .NET MAUI Class Library (Preview 13)

![Create Project - Visual Studio](images/maui-project-templates.png)

And has Item Templates for:

* Content Page (.NET MAUI)
* Content Page (C#) (.NET MAUI)
* Content View (.NET MAUI)
* Content View (C#) (.NET MAUI)
* Resource Dictionary (.NET MAUI)
* Resource Dictionary (XAML only)(.NET MAUI)
* Shell Page (.NET MAUI)

Now VS2022 extension is loaded with 25+ C# and XAML Code Snippets.

XAML Snippets for new Layouts, Gestures, Color, Style.

C# Snippets for Properties such as Attached, Bindable, ViewModel and Comet (MVU design pattern).

Types such as `record` and `record struct`.

Snippets for Method definition, Event Handler definition (async version also).

![Add New Item dialog - Visual Studio](images/add-new-item.png)

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

### .NET CLI Template

For making use of these templates cross-platform, have provided it as .NET CLI template package distributed via NuGet.

[![NuGet Package](https://badgen.net/nuget/v/VijayAnand.MauiTemplates/)](https://www.nuget.org/packages/VijayAnand.MauiTemplates/)

Install the template package from NuGet with the below command.

```shell
dotnet new --install VijayAnand.MauiTemplates
```

If you've already installed this package, then this can be updated to the latest version with the below command.

```shell
dotnet new --update-check
```
```shell
dotnet new --update-apply
```

This comes with with the following templates:

Name | Template Name | Type
:---: | :---: | :---:
.NET MAUI App | mauiapp | Project
.NET MAUI Class Library | mauiclasslib | Project
ContentPage | maui-page | Item
ContentPage (C#) | maui-page-cs | Item
ContentView | maui-view | Item
ContentView (C#) | maui-view-cs | Item
ShellPage | maui-shell | Item

![All-in-One .NET MAUI App Project Template](images/dotnetmaui-all-in-one-project-template-pinned.png)

#### Parameters:

In .NET CLI, all of these templates takes two parameters:

* Name: (Short notation: `-n`)

    The name of the project/page/view to create. _For pages/views, don't need to suffix it with .xaml_, it will get added.

    _If the name parameter is not specified, by default, the **.NET CLI template engine will take the current folder name as the filename** (current behaviour of the templating engine)._

* Namespace: (Short notation: `-na`)

    The namespace for the generated files.

* Now with more options while creating the class library project, ability to include NuGet packages on the fly for `CommunityToolkit.Maui`, `CommunityToolkit.Maui.Markup`, or both.

*Note: Parameter values are case-insensitive.*

Both project templates take the below optional parameters to include the official CommunityToolkit NuGet packages:

* `-it` | `--include-toolkit` - Accepted Values are `Yes` or `No` (default is `No`)
* `-im` | `--include-markup` - Accepted Values are `Yes` or `No` (default is `No`)

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

#### Usage:

After installation, use the below command(s) to create new artifacts using the template (both provide the same output):

With parameter names abbreviated:


.NET MAUI App:
```shell
dotnet new mauiapp -n MyApp -dp Hybrid
```
Option to include NuGet packages:
```shell
dotnet new mauiapp -n MyApp -dp Shell -it yes -im yes
```

.NET MAUI Class Library:
```shell
dotnet new mauiclasslib -n MyApp.Core
```
Option to include NuGet packages:
```shell
dotnet new mauiclasslib -n MyApp.Core -it yes -im yes
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

With parameter names expanded:

.NET MAUI App:
```shell
dotnet new mauiapp --name MyApp --design-pattern Hybrid
```
Option to include NuGet packages:
```shell
dotnet new mauiapp --name MyApp --design-pattern Shell --include-toolkit yes --include-markup yes
```

.NET MAUI Class Library:
```shell
dotnet new mauiclasslib --name MyApp.Core
```
```shell
dotnet new mauiclasslib --name MyApp.Core --include-toolkit yes --include-markup yes
```
Pages:
```shell
dotnet new maui-page --name LoginPage --namespace MyApp.Views
```
```shell
dotnet new maui-page-cs --name HomePage --namespace MyApp.Views
```
Views:
```shell
dotnet new maui-view --name CardView --namespace MyApp.Views
```
```shell
dotnet new maui-view-cs --name OrderView --namespace MyApp.Views
```
Shell:
```shell
dotnet new maui-shell --name AppShell --namespace MyApp
```
