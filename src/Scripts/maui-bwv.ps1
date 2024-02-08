# .NET MAUI ContentPage with BlazorWebView (XAML) Template
# Copyright 2024 Vijay Anand E G https://egvijayanand.in/

param(
    [Parameter(Mandatory, Position=0, HelpMessage="The name for the item being created.")]
    [Alias("n")]
    [string]$Name,

    [Parameter(HelpMessage="Forces content to be generated even if it would change existing files..")]
    [Alias("f")]
    [switch]$Force
)

$Env:WorkingDirectory = $pwd.Path

if ($Force)
{
    Invoke-Expression "dotnet new maui-bwv -n $Name --force"
}
else
{
    Invoke-Expression "dotnet new maui-bwv -n $Name"
}

$Env:WorkingDirectory = ''
