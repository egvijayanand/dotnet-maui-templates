# .NET MAUI ContentPage and ViewModel (C#) Template
# Copyright 2024 Vijay Anand E G https://egvijayanand.in/

param(
    [Parameter(Mandatory, Position=0, HelpMessage="The name for the page being created.")]
    [Alias("n")]
    [string]$Name,

    [Parameter(HelpMessage="Option to create the artifacts in the same folder.")]
    [Alias("sf", "same-folder")]
    [switch]$SameFolder,

    [Parameter(HelpMessage="Forces content to be generated even if it would change existing files..")]
    [Alias("f")]
    [switch]$Force
)

$Env:WorkingDirectory = $pwd.Path

if ($SameFolder)
{
    if ($Force)
    {
        Invoke-Expression "dotnet new maui-mvvm-cs -n $Name -sf --force"
    }
    else
    {
        Invoke-Expression "dotnet new maui-mvvm-cs -n $Name -sf"
    }
}
else
{
    if ($Force)
    {
        Invoke-Expression "dotnet new maui-mvvm-cs -n $Name --force"
    }
    else
    {
        Invoke-Expression "dotnet new maui-mvvm-cs -n $Name"
    }
}

$Env:WorkingDirectory = ''
