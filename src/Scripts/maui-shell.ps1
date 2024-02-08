# .NET MAUI Shell (XAML) Template
# Copyright 2024 Vijay Anand E G https://egvijayanand.in/

param(
    [Parameter(Mandatory, Position=0, HelpMessage="The name for the shell item being created.")]
    [Alias("n")]
    [string]$Name,

    [Parameter(HelpMessage="Specify whether it's a XAML only shell.")]
    [Alias("nc", "no-comments")]
    [switch]$NoComments,

    [Parameter(HelpMessage="Forces content to be generated even if it would change existing files..")]
    [Alias("f")]
    [switch]$Force
)

$Env:WorkingDirectory = $pwd.Path

if ($NoComments)
{
    if ($Force)
    {
        Invoke-Expression "dotnet new maui-shell -n $Name -nc --force"
    }
    else
    {
        Invoke-Expression "dotnet new maui-shell -n $Name -nc"
    }
}
else
{
    if ($Force)
    {
        Invoke-Expression "dotnet new maui-shell -n $Name --force"
    }
    else
    {
        Invoke-Expression "dotnet new maui-shell -n $Name"
    }
}

$Env:WorkingDirectory = ''
