# 🚀 API REST com ASP.NET Core

API RESTful moderna construída com **ASP.NET Core 8.0**, Entity Framework Core, e Docker support.

## ✨ **Funcionalidades**

- ✅ **CRUD** completo (Create, Read, Update, Delete)
- 📊 **Swagger UI** para testes
- 🛢️ **Entity Framework Core** + **SQL Server**
- 🐳 **Docker Compose** (API + Banco)
- 📈 **Logging** estruturado
- 🧪 **Unit Tests** + **Integration Tests**
- 🚀 **Auto-deploy** GitHub Actions

## 🛠️ **Tecnologias**
C# - ASPNET CORE - SQLServer - Docker

🚀 Como Executar
1. Pré-requisitos
bash

Copy code
.NET 8.0 SDK
Docker Desktop (opcional)
SQL Server (ou Docker)
Git

2. Clonar repositório
bash

Copy code
git clone https://github.com/SHERLON20/API_REST_ASPNET_CORE.git
cd API_REST_ASPNET_CORE

3. Opções de execução
A) Docker Compose (RECOMENDADO)
bash

Copy code
docker-compose up -d
# API: https://localhost:7001/swagger
# Admin: admin@admin.com / Admin123

B) Execução Local (.NET CLI)
bash

Copy code
# Banco (Docker)
docker-compose up db -d

# API
dotnet restore
dotnet ef database update
dotnet run --project src/API
C) Visual Studio

Copy code
F5 → Docker Compose ou IIS Express

🌐 Endpoints Swagger

Copy code
https://localhost:7001/swagger
https://localhost:7001/swagger/index.html

