# .NET MAUI Item (XAML) Template
# Copyright 2024 Vijay Anand E G https://egvijayanand.in/

param(
    [Parameter(Mandatory, Position=0, HelpMessage="The name for the item being created.")]
    [Alias("n")]
    [string]$Name,

    [Parameter(Mandatory, Position=1, HelpMessage="The base type for the item being created.")]
    [Alias("b", "base")]
    [string]$BaseType,

    [Parameter(Position=2, HelpMessage="The base generic type for the item being created.")]
    [Alias("g", "generic")]
    [PSDefaultValue(Value="")]
    [string]$GenericBaseType,

    [Parameter(HelpMessage="Specify whether it's a XAML only item.")]
    [Alias("xo", "xaml-only")]
    [switch]$XamlOnly,

    [Parameter(HelpMessage="Forces content to be generated even if it would change existing files..")]
    [Alias("f")]
    [switch]$Force
)

$Env:WorkingDirectory = $pwd.Path

if ($GenericBaseType -ne "")
{
    $Args = "-g $GenericBaseType";
}

if ($XamlOnly)
{
    if ($Force)
    {
        Invoke-Expression "dotnet new maui-item -n $Name -b $BaseType $Args -xo --force"
    }
    else
    {
        Invoke-Expression "dotnet new maui-item -n $Name -b $BaseType $Args -xo"
    }
}
else
{
    if ($Force)
    {
        Invoke-Expression "dotnet new maui-item -n $Name -b $BaseType $Args --force"
    }
    else
    {
        Invoke-Expression "dotnet new maui-item -n $Name -b $BaseType $Args"
    }
}

$Env:WorkingDirectory = ''
