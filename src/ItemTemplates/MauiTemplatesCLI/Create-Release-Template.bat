:: Creates a new NuGet package from the project file
@echo off
if exist .\bin\Release\VijayAnand.MauiTemplates.1.0.0.nupkg del .\bin\Release\VijayAnand.MauiTemplates.1.0.0.nupkg

echo Creating item template . . .
dotnet pack .\VijayAnand.MauiTemplates.csproj -c Release -p:PackageVersion=1.0.0
echo Process completed
pause