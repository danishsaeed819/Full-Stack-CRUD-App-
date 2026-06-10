# Full-Stack CRUD App — ASP.NET Core + SQL Server

A complete **Create, Read, Update, Delete** web application built with ASP.NET Core MVC, Entity Framework Core, SQL Server, and Bootstrap.

## Live URL (Local)

After starting the app, open:

**http://localhost:5223**

## Tech Stack

- ASP.NET Core MVC (.NET 9)
- Entity Framework Core
- SQL Server (LocalDB)
- Bootstrap 5
- Razor Views (server-side rendering)

## Features

- Full product CRUD with database persistence
- Normalized schema (`Categories` → `Products`)
- EF Core migrations for version-controlled schema changes
- Layered architecture: Controllers → Services → Repositories

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- SQL Server LocalDB (included with Visual Studio) or SQL Server Express
- [EF Core CLI tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) (first-time setup)

```powershell
dotnet tool install --global dotnet-ef --version 9.0.15
```

## Getting Started

### 1. Clone or open the project

```powershell
cd "c:\Users\Danish Saeed\Desktop\Full-Stack CRUD App — ASP.NET Core + SQL Server\CrudApp"
```

### 2. Restore packages

```powershell
dotnet restore
```

### 3. Apply database migrations (first time only)

```powershell
dotnet ef database update
```

### 4. Run the application

```powershell
dotnet run --launch-profile http
```

### 5. Open in browser

Go to: **http://localhost:5223**

The app opens on the **Products** page by default.

## Run Every Time

```powershell
cd "c:\Users\Danish Saeed\Desktop\Full-Stack CRUD App — ASP.NET Core + SQL Server\CrudApp"
dotnet run --launch-profile http
```

Press `Ctrl + C` in the terminal to stop the app.

## Run with Visual Studio

1. Open `CrudApp.csproj` in Visual Studio
2. Press **F5** or click the green **Run** button

## Project Structure

```
CrudApp/
├── Controllers/       # MVC controllers
├── Data/            # ApplicationDbContext
├── Migrations/      # EF Core migrations
├── Models/
│   ├── Entities/    # Category, Product
│   └── ViewModels/  # Form and display models
├── Repositories/    # Data access layer
├── Services/        # Business logic layer
└── Views/           # Razor views (Bootstrap UI)
```

## Database Connection

Default connection string in `appsettings.json`:

```
Server=(localdb)\mssqllocaldb;Database=CrudAppDb;Trusted_Connection=True;...
```

To use a different SQL Server instance, update `ConnectionStrings:DefaultConnection` in `appsettings.json`.

## Troubleshooting

| Issue | Solution |
|-------|----------|
| HTTPS certificate error | Use `dotnet run --launch-profile http` |
| Port already in use | Stop the other running instance (`Ctrl + C`) |
| Database not found | Run `dotnet ef database update` |
| `dotnet ef` not found | Run `dotnet tool install --global dotnet-ef` |

## License

This project is for learning and portfolio use.
