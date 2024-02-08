# .NET MAUI ResourceDictionary Template
# Copyright 2024 Vijay Anand E G https://egvijayanand.in/

param(
    [Parameter(Mandatory, Position=0, HelpMessage="The name for the item being created.")]
    [Alias("n")]
    [string]$Name,

    [Parameter(HelpMessage="Specify whether it's a XAML only item.")]
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
        Invoke-Expression "dotnet new maui-resdict -n $Name -xo --force"
    }
    else
    {
        Invoke-Expression "dotnet new maui-resdict -n $Name -xo"
    }
}
else
{
    if ($Force)
    {
        Invoke-Expression "dotnet new maui-resdict -n $Name --force"
    }
    else
    {
        Invoke-Expression "dotnet new maui-resdict -n $Name"
    }
}

$Env:WorkingDirectory = ''
