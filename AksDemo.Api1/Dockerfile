FROM mcr.microsoft.com/dotnet/aspnet:6.0
COPY AksDemo.Api1/bin/publish ./app
WORKDIR /app
ENTRYPOINT ["dotnet", "AksDemo.Api1.dll"]