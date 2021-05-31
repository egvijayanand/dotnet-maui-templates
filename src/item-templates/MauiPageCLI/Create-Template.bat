:: Creates a new NuGet package from the project file
@echo off
if exist .\bin\Debug\VijayAnand.MauiPage.1.0.0.nupkg del .\bin\Debug\VijayAnand.MauiPage.1.0.0.nupkg
echo Creating item template . . .
dotnet pack .\VijayAnand.MauiPage.csproj
echo Process completed
pause