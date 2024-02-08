# .NET MAUI ContentView (XAML) Template
# Copyright 2024 Vijay Anand E G https://egvijayanand.in/

param(
    [Parameter(Mandatory, Position=0, HelpMessage="The name for the view being created.")]
    [Alias("n")]
    [string]$Name,

    [Parameter(HelpMessage="Specify whether it's a XAML only view.")]
    [Alias("xo", "xaml-only")]
    [switch]$XamlOnly,

    [Parameter(HelpMessage="Forces content to be generated even if it would change existing files..")]
    [Alias("f")]
    [switch]$Force
)

$Env:WorkingDirectory = $pwd.Path

if ($XamlOnly)
{
    if ($Force)
    {
        Invoke-Expression "dotnet new maui-view -n $Name -xo --force"
    }
    else
    {
        Invoke-Expression "dotnet new maui-view -n $Name -xo"
    }
}
else
{
    if ($Force)
    {
        Invoke-Expression "dotnet new maui-view -n $Name --force"
    }
    else
    {
        Invoke-Expression "dotnet new maui-view -n $Name"
    }
}

$Env:WorkingDirectory = ''
