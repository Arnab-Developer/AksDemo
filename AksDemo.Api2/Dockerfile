FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY AksDemo.Api2/bin/publish ./app
WORKDIR /app
ENTRYPOINT ["dotnet", "AksDemo.Api2.dll"]