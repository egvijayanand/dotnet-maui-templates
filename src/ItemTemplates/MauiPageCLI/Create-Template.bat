:: Creates a new NuGet package from the project file
@echo off
if exist .\bin\Debug\VijayAnand.MauiPage.1.0.1.nupkg del .\bin\Debug\VijayAnand.MauiPage.1.0.1.nupkg

echo Creating item template . . .
dotnet pack .\VijayAnand.MauiPage.csproj -p:PackageVersion=1.0.1
echo Process completed
pause