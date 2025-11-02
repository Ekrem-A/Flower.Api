# 1. aþama: build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# önce projeleri teker teker kopyalýyoruz ki restore cache'lenebilsin
COPY ["Flower.Api/Flower.Api.csproj", "Flower.Api/"]
COPY ["Flower.Application/Flower.Application.csproj", "Flower.Application/"]
COPY ["Flower.Domain/Flower.Domain.csproj", "Flower.Domain/"]
COPY ["Flower.Infrastructure/Flower.Infrastructure.csproj", "Flower.Infrastructure/"]

# þimdi restore
RUN dotnet restore "Flower.Api/Flower.Api.csproj"

# artýk tüm solution'ý kopyalayabiliriz
COPY . .

# build/publish
WORKDIR "/src/Flower.Api"
RUN dotnet publish "Flower.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# 2. aþama: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# dýþarýya 8080 açalým
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "Flower.Api.dll"]
