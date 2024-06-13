# Worksuite.Phnx

`Worksuite.Phnx` is forked from [Phnx](https://github.com/phoenix-apps/Phnx).

## Build

```
dotnet build src/Phnx/Phnx.csproj --configuration Release
```

## Pack

```
dotnet pack src/Phnx/Phnx.csproj --configuration Release
```

## Push

```
dotnet nuget push --source "https://pkgs.dev.azure.com/totalmobile/_packaging/TotalMobile/nuget/v3/index.json" --api-key az ./src/Phnx/bin/Release/Worksuite.Phnx.1.0.0.7.nupkg --interactive
```
