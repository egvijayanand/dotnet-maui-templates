:: Installs the NuGet package
@echo off

if [%1]==[] (call Error "Build configuration input is not provided." & pause & goto end)

set config=%1

:: Package Name

if not exist PackageName.txt (call Error "Package name file not available." & goto end)

set /P packageName=<PackageName.txt

if [%packageName%]==[] (call Error "Package name not configured." & goto end)

:: Package Version

if not exist PackageVersion.txt (call Error "Version file not available." & goto end)

set /P packageVersion=<PackageVersion.txt

if [%packageVersion%]==[] (call Error "Version # not configured." & goto end)

:: Modify .NET SDK Version
::if exist global.json (call Error "Verify the .NET SDK Version" & goto end)

call Info ".NET SDK Version"
dotnet --version

:: Validate the Package

echo.
call Info "Validating %packageName% ver. %packageVersion% ..."

templates analyze -p .\bin\%config%\%packageName%.%packageVersion%.nupkg

echo.
if %errorlevel% == 0 (call Info "Package validated.") else (call Error "Package validation failed." & goto end)

:: Installing the Package

echo.
call Info "Installing the %packageName% %config% build template ver. %packageVersion% ..."

dotnet new install .\bin\%config%\%packageName%.%packageVersion%.nupkg

if %errorlevel% == 0 (call Success "Process completed.") else (call Error "Package install failed.")

:end
