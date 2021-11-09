FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY AksDemo.Api1/bin/publish ./app
WORKDIR /app
ENTRYPOINT ["dotnet", "AksDemo.Api1.dll"]