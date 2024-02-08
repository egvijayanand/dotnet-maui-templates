:: .NET MAUI ContentPage (C#) Template
:: Copyright 2024 Vijay Anand E G https://egvijayanand.in/

@echo off

if not "%1"=="" (if not "%1"=="-h" (goto process))

echo .NET MAUI ContentPage (C#)
echo.
echo Requires a mandatory input: page name

goto end

:process

set WorkingDirectory=%cd%

set page_name=%1

dotnet new maui-page-cs -n %page_name% %~2 %~3 %~4 %~5

set WorkingDirectory=
set page_name=

:end
