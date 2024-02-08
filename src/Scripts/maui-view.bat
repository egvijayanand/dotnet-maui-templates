:: .NET MAUI ContentView Template
:: Copyright 2024 Vijay Anand E G https://egvijayanand.in/

@echo off

if not "%1"=="" (if not "%1"=="-h" (goto process))

echo .NET MAUI ContentView in XAML
echo.
echo Requires a mandatory input: view name
echo Takes an optional input: xaml only

goto end

:process

set WorkingDirectory=%cd%

set view_name=%1
if "%2"=="" (set options=_) else (set options=%2)

if "%options%"=="_" (dotnet new maui-view -n %view_name%) else (if "%options:~0,1%"=="-" (dotnet new maui-view -n %view_name% %options% %~3 %~4 %~5 %~6) else (echo Invalid input.))

set WorkingDirectory=
set view_name=
set options=

:end
