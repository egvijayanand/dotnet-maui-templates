:: Creates a new NuGet package from the project file
@echo off
if exist .\bin\Release\VijayAnand.MauiTemplates.1.0.3.nupkg del .\bin\Release\VijayAnand.MauiTemplates.1.0.3.nupkg

echo Creating NuGet package ...
dotnet pack .\VijayAnand.MauiTemplates.csproj -c Release -p:PackageVersion=1.0.3
echo Process completed
pause