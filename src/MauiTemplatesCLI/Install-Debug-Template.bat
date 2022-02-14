:: Installs the NuGet package
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

::call Info "Package Name: %packageName%"
::call Info "Version #: %packageVersion%"

call Info "Installing the %packageName% Debug build template ver. %packageVersion% ..."

dotnet new --install .\bin\Debug\%packageName%.%packageVersion%.nupkg

if %errorlevel% == 0 (call Success "Process completed.") else (call Error "Package install failed.")

:end
pause