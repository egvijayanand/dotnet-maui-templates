### Project and Item Templates for developing .NET MAUI App that runs on iOS, Android, macOS, and Windows 

Project template for .NET MAUI Class Library and is named as `mauiclasslib`

Item templates for ContentPage, ContentView, and ShellPage in XAML and named as `maui-page`, `maui-view`, and `maui-shell` respectively.

All of these templates currently target .NET MAUI Preview 12.

To install the template NuGet package, use the below .NET CLI command:

```shell
dotnet new --install VijayAnand.MauiTemplates
```

If you've already installed this package, then it can be updated to the latest version with the below command:

```shell
dotnet new --update-check
dotnet new --update-apply
```
Use the below .NET CLI command to create the library project, pages, and views out these templates:

```shell
dotnet new mauiclasslib -n MyApp.Core
```
Now with more options while creating the library project:
```shell
dotnet new mauiclasslib -n MyApp.Core --include-toolkit yes --include-markup yes
```
```shell
dotnet new maui-page -n LoginPage -na MyApp.Views
```
```shell
dotnet new maui-view -n CardView -na MyApp.Views
```
```shell
dotnet new maui-shell -n AppShell -na MyApp
```
Here `-n` denotes the name of the project/page/view that is to be created (for pages/views, don't need to suffix it with .xaml, it will be added automatically) (Can also be specified as `--name`).

In library project options, `--include-toolkit` and `--include-markup` can be used with shortened parameter names such as `-it` and `-im` respectively.

For more details: run this command in the terminal:
```shell
dotnet new mauiclasslib --help
```

*Note: If name parameter is not provided, the .NET CLI template engine will take the current folder name in the context as its name.*

And `-na` denotes the namespace under which the file is to be created (Can also be specified as `--namespace`).