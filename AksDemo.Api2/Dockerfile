FROM mcr.microsoft.com/dotnet/aspnet:6.0
COPY AksDemo.Api2/bin/publish ./app
WORKDIR /app
ENTRYPOINT ["dotnet", "AksDemo.Api2.dll"]