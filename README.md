## .NET MAUI Project and Item Templates
This repository is to host the .NET MAUI Project and Item templates

We all know that .NET MAUI is an evolution of Xamarin.Forms.

And .NET 6 Preview 6 just got released last week (Wed, Jul 14, 2021) and now .NET 6 Preview 7 released on Tue, Aug 10, 2021.

Templates have been updated to support the latest release.

### For VS2022 users:

To provide an integrated experience, a VS extension has been developed to host these templates.

Extension is made available in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=egvijayanand.maui-templates) and even more easier, can be installed from within Visual Studio itself (Extensions -> Manage Extensions / Alt + X + M).

![Manage Extensions - Visual Studio](images/vs-manage-extensions.png)

This has project template for both MAUI and MAUI Blazor project and it has been named as:

* .NET MAUI App (Preview 7)
* .NET MAUI Blazor App (Preview 7)

![Create Project - Visual Studio](images/maui-project-templates.png)

And Item template for ContentPage and ContentView, in both XAML and C#, and has been named as:

* Content Page (.NET MAUI)
* Content Page (C#) (.NET MAUI)
* Content View (.NET MAUI)
* Content View (C#) (.NET MAUI)

![Add New Item dialog - Visual Studio](images/add-new-item.png)

### For VS2019 users:

Now, ContentPage is completely moved into .NET MAUI world with a brand new xml namespace and using directive.

So that the existing Xamarin.Forms item templates cannot be used as is from now on and modifying it every time is painful.

Hence have created a VS extension exclusively to be used with .NET MAUI projects.

Grab these templates from the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=egvijayanand.maui-item-templates) and even more easier, can be installed from within Visual Studio itself (Extensions -> Manage Extensions / Alt + X + M)

It has templates for ContentPage and ContentView, in both XAML and C#, and has been named as:

* Content Page (.NET MAUI)
* Content Page (C#) (.NET MAUI)
* Content View (.NET MAUI)
* Content View (C#) (.NET MAUI)

![Add New Item dialog - Visual Studio](images/add-new-item.png)

### .NET CLI Template

For making use of these templates cross-platform, have provided it as .NET CLI item template distributed via NuGet.

[![NuGet Package](https://badgen.net/nuget/v/VijayAnand.MauiTemplates/)](https://www.nuget.org/packages/VijayAnand.MauiTemplates/)

Install the item template from NuGet with the below command.

```console
dotnet new --install VijayAnand.MauiTemplates
```

Starting with, ContentPage template is named as **maui-page** 

And ContentView template is named as **maui-view**

Both these templates takes two parameters:

Name: (Short form: -n)

The name of the file to create, _don't need to suffix it with xaml_, it will get added.

_If the name parameter is not specified, by default, the **.NET CLI template engine will take the current folder name as the filename** (current behaviour of the templating engine)._

Namespace: (Short form: -na)

The namespace for the generated files.

After installation, run the below command to make use of the template (both provide the same result):

```console
dotnet new maui-page -n MainPage -na TestApp.Views
```

```console
dotnet new maui-page --name MainPage --namespace TestApp.Views
```

```console
dotnet new maui-view -n CardView -na TestApp.Views
```

```console
dotnet new maui-view --name CardView --namespace TestApp.Views
```
