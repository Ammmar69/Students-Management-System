# Student Management System

A **Student Management System** built with **ASP.NET Core MVC** and **Entity Framework Core**.
This project demonstrates CRUD operations, database integration, and MVC architecture for managing student records.
This project is a CRUD-based ASP.NET Core MVC application where users can Create, Read, Update, and Delete student records using Entity Framework Core.

## Features

* Add, update, and delete student records
* View list of students
* Entity Framework Core with Code-First Migrations
* ASP.NET Core MVC architecture
* Responsive Razor views

## Tech Stack

* **Backend:** ASP.NET Core 6 / 7 (depending on your SDK)
* **Frontend:** Razor Views (HTML, CSS, Bootstrap)
* **Database:** SQL Server (via Entity Framework Core)
* **ORM:** Entity Framework Core

## Project Structure

```
studentsmanagementsystem/
 ├── Controllers/         # MVC Controllers
 ├── Models/              # Data Models & DbContext
 ├── Views/               # Razor Views
 ├── Data/Migrations/     # EF Core Migrations
 ├── appsettings.json     # App configuration
 ├── Program.cs           # Entry point
 ├── *.csproj             # Project file
 └── *.sln                # Solution file
```

## Getting Started

### Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or later)
* SQL Server / LocalDB

### Setup

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/studentsmanagementsystem.git
   cd studentsmanagementsystem/studentsmanagementsystem
   ```

2. Update database connection string in `appsettings.json`.

3. Apply migrations:

   ```bash
   dotnet ef database update
   ```

4. Run the project:

   ```bash
   dotnet run
   ```

5. Open in browser:

   ```
   https://localhost:5001
   ```

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you’d like to change.

## License

This project is licensed under the MIT License.


