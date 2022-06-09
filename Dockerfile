FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY ./Album-Api/Album.Api/bin/Release/net5.0/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "Album.Api.dll"]
