#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Visualizacao/CadastroDeVeciulos.Visualizacao/CadastroDeVeciulos.Visualizacao.csproj", "Visualizacao/CadastroDeVeciulos.Visualizacao/"]
COPY ["Core/Dominio/CadastroVeiculo.Aplicacao/CadastroVeiculo.Aplicacao.csproj", "Core/Dominio/CadastroVeiculo.Aplicacao/"]
COPY ["CadastroDeVeiculo.Dominio/CadastroDeVeiculo.Dominio.csproj", "CadastroDeVeiculo.Dominio/"]
COPY ["CadastroDeVeiculo.Data/CadastroDeVeiculo.Data.csproj", "CadastroDeVeiculo.Data/"]
RUN dotnet restore "Visualizacao/CadastroDeVeciulos.Visualizacao/CadastroDeVeciulos.Visualizacao.csproj"
COPY . .
WORKDIR "/src/Visualizacao/CadastroDeVeciulos.Visualizacao"
RUN dotnet build "CadastroDeVeciulos.Visualizacao.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CadastroDeVeciulos.Visualizacao.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CadastroDeVeciulos.Visualizacao.dll"]
