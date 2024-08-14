# Use the official ASP.NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Use the official .NET SDK as a build environment
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SchoolManagementApp.MVC.csproj", "./"]
RUN dotnet restore "./SchoolManagementApp.MVC.csproj"
COPY . .
WORKDIR "/src/SchoolManagementApp.MVC"
RUN dotnet build "SchoolManagementApp.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SchoolManagementApp.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SchoolManagementApp.MVC.dll"]
