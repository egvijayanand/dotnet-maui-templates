# Partial Class (C#) Template
# Copyright 2024 Vijay Anand E G https://egvijayanand.in/

param(
    [Parameter(Mandatory, Position=0, HelpMessage="The name for the type being created.")]
    [Alias("n")]
    [string]$Name,

    [Parameter(Position=1, HelpMessage="The base type for the item being created.")]
    [Alias("b", "base")]
    [PSDefaultValue(Value="object")]
    [string]$BaseType,

    [Parameter(HelpMessage="The access modifier for the item being created.")]
    [Alias("am", "access-modifier")]
    [PSDefaultValue(Value="public")]
    [ValidateSet("public", "internal", "protected", "private")]
    [string]$AccessModifier,

    [Parameter(HelpMessage="Specify whether it's a abstract class.")]
    [Alias("ab")]
    [switch]$Abstract,

    [Parameter(HelpMessage="Specify whether it's a partial class.")]
    [Alias("p")]
    [switch]$Partial,

    [Parameter(HelpMessage="Specify whether it's a sealed class.")]
    [Alias("s")]
    [switch]$Sealed,

    [Parameter(HelpMessage="Specify whether it's a static class.")]
    [Alias("st")]
    [switch]$Static,

    [Parameter(HelpMessage="Specify whether it uses file scoped namespace.")]
    [Alias("fsn", "file-scoped-namespace")]
    [switch]$FileScopedNamespace,

    [Parameter(HelpMessage="Forces content to be generated even if it would change existing files.")]
    [Alias("f")]
    [switch]$Force
)

$Env:WorkingDirectory = $pwd.Path

if ($BaseType -ne "")
{
    $Args = "-b $BaseType"
}

if ($AccessModifier -ne "")
{
    $Args += " -am $AccessModifier"
}

if ($Abstract)
{
    $Args += " -ab";
}

if ($Partial)
{
    $Args += " -p";
}

if ($Sealed)
{
    $Args += " -s";
}

if ($Static)
{
    $Args += " -st";
}

if ($FileScopedNamespace)
{
    $Args += " -fsn";
}

if ($Force)
{
    $Args += " --force";
}

Invoke-Expression "dotnet new class-cs -n $Name $Args"

$Env:WorkingDirectory = ''
