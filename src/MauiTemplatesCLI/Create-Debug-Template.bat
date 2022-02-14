:: Creates a new NuGet package from the project file
@echo off

:: Modify .NET SDK Version
if exist global.json ren global.json global.json.bak

:: Package Name

if not exist PackageName.txt (call Error "Package name file not available." & goto end)

set /P packageName=<PackageName.txt

if [%packageName%]==[] (call Error "Package name not configured." & goto end)

:: Package Version

if not exist PackageVersion.txt (call Error "Version file not available." & goto end)

set /P packageVersion=<PackageVersion.txt

if [%packageVersion%]==[] (call Error "Version # not configured." & goto end)

::echo Package Name: %packageName%
::echo Version #: %packageVersion%

call Info ".NET SDK Version"
dotnet --version

if exist .\bin\Debug\%packageName%.%packageVersion%.nupkg del .\bin\Debug\%packageName%.%packageVersion%.nupkg

call Info "Creating %packageName% template ver. %packageVersion% NuGet package in Debug mode ..."

dotnet pack .\VijayAnand.MauiTemplates.csproj -c Debug -p:PackageVersion=%packageVersion%

if %errorlevel% == 0 (call Success "Process completed.") else (call Error "Package creation failed.")

:end
pause