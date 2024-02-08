:: .NET MAUI ContentView (C#) Template
:: Copyright 2024 Vijay Anand E G https://egvijayanand.in/

@echo off

if not "%1"=="" (if not "%1"=="-h" (goto process))

echo .NET MAUI ContentView (C#)
echo.
echo Requires a mandatory input: page name

goto end

:process

set WorkingDirectory=%cd%

set view_name=%1

dotnet new maui-view-cs -n %view_name% %~2 %~3 %~4 %~5

set WorkingDirectory=
set view_name=

:end
