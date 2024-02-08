:: .NET MAUI ResourceDictionary Template
:: Copyright 2024 Vijay Anand E G https://egvijayanand.in/

@echo off

if not "%1"=="" (if not "%1"=="-h" (goto process))

echo .NET MAUI ResourceDictionary in XAML
echo.
echo Requires a mandatory input: item name
echo Takes an optional input: xaml only

goto end

:process

set WorkingDirectory=%cd%

set item_name=%1
if "%2"=="" (set options=_) else (set options=%2)

if "%options%"=="_" (dotnet new maui-resdict -n %item_name%) else (if "%options:~0,1%"=="-" (dotnet new maui-resdict -n %item_name% %options% %~3 %~4 %~5 %~6) else (echo Invalid input.))

set WorkingDirectory=
set item_name=
set options=

:end
