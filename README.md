
# 🦸‍♂️ Super Hero CRUD Application

Este projeto é um sistema de gerenciamento de super-heróis, desenvolvido com  **.NET (C#)** no backend. Permite criar, visualizar, editar e excluir heróis.

---

## 🚀 Tecnologias Utilizadas

### 🖥️ Backend
- **C#**
- **.NET 7/8 (ASP.NET Web API)**
- **Entity Framework Core**
- **SQL Server (ou outro banco relacional)**

---

## ⚙️ Funcionalidades

- ✅ Listar todos os heróis
- ✅ Adicionar um novo herói
- ✅ Editar informações de um herói
- ✅ Excluir um herói
- ✅ Consumo de API RESTful
- ✅ Interface amigável

---

## 🏗️ Como Executar o Projeto

### 🔧 Backend (ASP.NET)
1. Navegue até a pasta do backend:
```bash
cd SuperHeroBackend
```
2. Execute o projeto:
```bash
dotnet build
dotnet run
```
3. A API estará disponível em:
```
https://localhost:7127/api/SuperHeros
```

---

## 🔗 API Endpoints (Backend)

| Verbo | Rota                           | Ação                 |
|-------|----------------------------------|----------------------|
| GET   | `/api/SuperHeros`               | Listar todos         |
| GET   | `/api/SuperHeros/{id}`          | Obter por ID         |
| POST  | `/api/SuperHeros`               | Criar novo           |
| PUT   | `/api/SuperHeros/{id}`          | Atualizar existente  |
| DELETE| `/api/SuperHeros/{id}`          | Deletar              |

---

## 💻 Requisitos

- Node.js (v18+)
- .NET SDK (7 ou superior)
- Banco de dados SQL Server (ou equivalente)


