# Simple Blog CRUD with CQRS in .NET Core, C#, MediatR, and SQL Server

A POC demonstrating CQRS patterns for blog management using SQL Server as the database.

## Features

CRUD operations for blog posts
CQRS implementation for command-query separation
MediatR for mediating commands and queries
SQL Server for data persistence
Potential for event sourcing and eventual consistency (if applicable)
## Technologies

- .NET Core 6
- C# 10
- MediatR
- SQL Server
- Entity Framework Core (for interacting with SQL Server)
## Getting Started

Prerequisites:
.NET Core 6 SDK
SQL Server instance
Clone the repository:
Bash
git clone https://github.com/[your-username]/simple-blog-cqrs-dotnet-sqlserver.git
Use code with caution. Learn more
Install dependencies:
Bash
cd simple-blog-cqrs-dotnet-sqlserver
dotnet restore
Use code with caution. Learn more
Configure database connection:
Update the appsettings.json file with your SQL Server connection string.
Run the application:
Bash
dotnet run
