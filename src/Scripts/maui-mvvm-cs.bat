:: .NET MAUI ContentPage and ViewModel (C#) Template
:: Copyright 2024 Vijay Anand E G https://egvijayanand.in/

@echo off

if not "%1"=="" (if not "%1"=="-h" (goto process))

echo .NET MAUI ContentPage and ViewModel (C#)
echo.
echo Requires a mandatory input: item name

goto end

:process

set WorkingDirectory=%cd%

set item_name=%1
if "%2"=="" (set options=_) else (set options=%2)

if "%options%"=="_" (dotnet new maui-mvvm-cs -n %item_name%) else (if "%options:~0,1%"=="-" (dotnet new maui-mvvm-cs -n %item_name% %options% %~3 %~4 %~5 %~6) else (echo Invalid input.))

set WorkingDirectory=
set item_name=
set options=

:end
