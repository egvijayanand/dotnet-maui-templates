:: .NET MAUI Shell (C#) Template
:: Copyright 2024 Vijay Anand E G https://egvijayanand.in/

@echo off

if not "%1"=="" (if not "%1"=="-h" (goto process))

echo .NET MAUI Shell (C#)
echo.
echo Requires a mandatory input: shell item name

goto end

:process

set WorkingDirectory=%cd%

set type_name=%1

dotnet new maui-shell-cs -n %type_name% %~2 %~3 %~4 %~5

set WorkingDirectory=
set type_name=

:end
