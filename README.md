# QuestGameDetective

QuestGameDetective is a detective-themed ASP.NET Core Web API built with Clean Architecture, CQRS and MediatR.

Players can investigate murder cases, accept quests, examine suspects and solve cases by accusing the correct suspect.

---

## Features

- JWT Authentication
- Role-based authorization (Admin/User)
- Murder case management
- Quest progression system
- Clean Architecture
- CQRS with MediatR
- Repository Pattern

---

## Tech Stack

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- MediatR
- ASP.NET Identity
- JWT Authentication

---

## Architecture

The project follows Clean Architecture with four layers:

- API
- Application
- Domain
- Infrastructure

CQRS and MediatR are used to separate commands and queries.

---

## Test Users

### Admin
Email: `admin@test.com`  
Password: `Admin123!`

### User
Email: `user@test.com`  
Password: `User123!`

---

## Setup

1. Clone the repository

2. Open the solution in Visual Studio

3. Add JWT settings to `appsettings.Development.json`

> The JWT key is not included in the repository.  
> Please contact me if access is needed.

4. Update the database

```powershell
dotnet ef database update --project QuestGameDetective.Infrastructure --startup-project QuestGameDetective.API
```

5. Run the project

```powershell
dotnet run --project QuestGameDetective.API
```

---

## API Testing

A Postman collection is included for testing the API endpoints.