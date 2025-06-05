
# 🦸‍♂️ Super Hero CRUD Application

Este projeto é um sistema de gerenciamento de super-heróis, desenvolvido com **Angular** no frontend e **.NET (C#)** no backend. Permite criar, visualizar, editar e excluir heróis.

---

## 🚀 Tecnologias Utilizadas

### 🔗 Frontend
- **Angular** (v14 ou superior)
- **TypeScript**
- **HTML5**
- **CSS3**
- **Angular Standalone Components**
- **RxJS**
- **Angular HTTP Client**

### 🖥️ Backend
- **C#**
- **.NET 7/8 (ASP.NET Web API)**
- **Entity Framework Core**
- **SQL Server (ou outro banco relacional)**

---

## 📂 Estrutura do Projeto

```
/SuperHeroFront (Frontend Angular)
    ├── components/
    ├── services/
    ├── models/
    ├── app.ts
    ├── index.html
    ├── styles.css
    └── README.md

/SuperHeroAPI (Backend .NET)
    ├── Controllers/
    ├── Models/
    ├── Data/
    ├── Program.cs
    ├── appsettings.json
    └── README.md
```

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
cd SuperHeroAPI
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

### 🌐 Frontend (Angular)
1. Navegue até a pasta do frontend:
```bash
cd SuperHeroFront
```
2. Instale as dependências:
```bash
npm install
```
3. Execute a aplicação:
```bash
ng serve
```
4. Acesse no navegador:
```
http://localhost:4200
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
- Angular CLI (`npm install -g @angular/cli`)
- .NET SDK (7 ou superior)
- Banco de dados SQL Server (ou equivalente)

---

## 🤝 Contribuição

Contribuições são bem-vindas! Abra uma issue ou envie um pull request.

---

## 📜 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
