:: Removes the installed project template
@echo off

:: Modify .NET SDK Version
if exist global.json ren global.json global.json.bak

:: Package Name

if not exist PackageName.txt (call Error "Package name file not available." & goto end)

set /P packageName=<PackageName.txt

if [%packageName%]==[] (call Error "Package name not configured." & goto end)

::echo Package Name: %packageName%

call Info ".NET SDK Version"
dotnet --version

call Info "Uninstalling %packageName% ..."

dotnet new --uninstall %packageName%

if %errorlevel% == 0 (call Success "Process completed.") else (call Error "Package uninstall failed.")

:end
pause