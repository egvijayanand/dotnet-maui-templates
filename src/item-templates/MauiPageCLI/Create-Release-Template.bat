:: Creates a new NuGet package from the project file
@echo off
if exist .\bin\Release\VijayAnand.MauiPage.1.0.1.nupkg del .\bin\Release\VijayAnand.MauiPage.1.0.1.nupkg

echo Creating item template . . .
dotnet pack .\VijayAnand.MauiPage.csproj -c Release -p:PackageVersion=1.0.1
echo Process completed
pause