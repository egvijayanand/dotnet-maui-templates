# .NET MAUI Project and Item Templates
This repository is to host the .NET MAUI Project and Item templates

We all know that .NET MAUI is an evolution to Xamarin.Forms.

And .NET 6 Preview 4 just got released last week in the **MSBuild 2021**.

With this new release, ContentPage is completely moved into .NET MAUI world with a brand new xml namespace and using directive.

So that the existing Xamarin.Forms item templates cannot be used as is from now on and modfifying it everytime is painful.

Hence have created new item templates exclusively to be used with .NET MAUI projects (both for XAML and C#).

Grab these templates from the [Releases](https://github.com/egvijayanand/dotnet-maui-templates/releases/tag/1.0.0).

* MauiPageCS.zip
* MauiPageXaml.zip

To make it work, copy the 2 zip files to any of the below mentioned directory in your local machine (Create the folder structure, if not already present).

For current user - %UserProfile% is the users' directory, run echo command to know the exact location

```console
echo %UserProfile%
```
```console
"%UserProfile%\Documents\Visual Studio 2019\Templates\ItemTemplates\Visual C#\MAUI"
```

For all users:

Copy to this folder, if you want this to be available for all users accessing that machine (requires Administrator privilege) 

_(Note: Visual Studio edition needs to be updated properly, have mentioned below as **Preview**):_

```console
echo %ProgramFiles(x86)%
```

```console
"%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Preview\Common7\IDE\ItemTemplates\CSharp"
```

***After copying those Zip files, it is mandatory to restart the Visual Studio instance for custom templates like these to take effect.***

Screenshot shown for reference - Templates categorized as MAUI for quick access:

![Add New Item dialog - Visual Studio](https://github.com/egvijayanand/dotnet-maui-templates/blob/main/images/add-new-item.png)
