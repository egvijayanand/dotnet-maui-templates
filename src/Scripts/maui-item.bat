:: .NET MAUI Item Template
:: Copyright 2024 Vijay Anand E G https://egvijayanand.in/

@echo off

if not "%1"=="" (if not "%1"=="-h" (goto validate))

echo .NET MAUI Item in XAML
echo.
echo Requires two mandatory inputs: type name and base type name
echo Takes two optional inputs: generic base type name and xaml only

goto end

:validate

if "%1"=="" (if "%2"=="" (echo Both type name and base type name are not provided. && goto end))

:: 1st parameter cannot be empty if 2nd parameter is available.
if not "%1"=="" (if "%2"=="" (echo Base type name is not provided. && goto end) else (goto process))

:process

set WorkingDirectory=%cd%

set type_name=%1
set base_type_name=%2
if "%3"=="" (set options=_) else (set options=%~3)

if "%options%"=="_" (dotnet new maui-item -n %type_name% -b %base_type_name%) else (if "%options:~0,1%"=="-" (dotnet new maui-item -n %type_name% -b %base_type_name% %options% %~4 %~5 %~6 %~7 %~8 %~9) else (dotnet new maui-item -n %type_name% -b %base_type_name% -g %options% %~4 %~5 %~6 %~7 %~8 %~9))

set WorkingDirectory=
set type_name=
set base_type_name=
set options=

:end
