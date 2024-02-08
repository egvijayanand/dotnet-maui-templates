:: Partial Class (C#) Item Template
:: Copyright 2024 Vijay Anand E G https://egvijayanand.in/

@echo off

if not "%1"=="" (if not "%1"=="-h" (goto process))

echo Partial Class (C#) template.
echo.
echo Requires a mandatory input: type name
echo Takes an optional input: base type

goto end

:process

set WorkingDirectory=%cd%

set type_name=%1
if "%2"=="" (set options=_) else (set options=%~2)

if "%options%"=="_" (dotnet new class-cs -n %type_name%) else (if "%options:~0,1%"=="-" (dotnet new class-cs -n %type_name% %options% %~3 %~4 %~5 %~6 %~7 %~8 %~9) else (dotnet new class-cs -n %type_name% -b %options% %~3 %~4 %~5 %~6 %~7 %~8 %~9))

set WorkingDirectory=
set type_name=
set options=

:end
