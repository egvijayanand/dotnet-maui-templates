:: Creates a new NuGet package from the project file
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

:: Check whether the context is git repository or not
git rev-parse --is-inside-work-tree

:: Retrieve the hash of the latest commit
if %errorlevel% == 0 (for /F "tokens=*" %%g in ('git rev-parse --short HEAD') do (set revisionId=+sha.%%g)) else (set revisionId=)

:: Modify .NET SDK Version
::if exist global.json (call Error "Verify the .NET SDK Version" & goto end)
::if exist global.json.net6.bak ren global.json.net6.bak global.json

echo.
call Info ".NET SDK Version"

dotnet --version

echo.
call Info "Deleting existing package ..."

if exist .\bin\%config%\%packageName%.%packageVersion%.nupkg del .\bin\%config%\%packageName%.%packageVersion%.nupkg

echo.
call Info "Creating %packageName% template ver. %packageVersion% NuGet package in %config% mode ..."

echo.
dotnet pack .\VijayAnand.MauiTemplates.csproj -c %config% -p:PackageVersion=%packageVersion%%revisionId%

echo.
if %errorlevel% == 0 (call Success "Process completed.") else (call Error "Package creation failed.")

:: Revert the changes
::if exist global.json ren global.json global.json.net6.bak

:end
