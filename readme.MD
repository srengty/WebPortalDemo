# Web Portal Demo Project
FT ST M 17 ASP.NET Project and also as Term Project.

|                      |                         |
|----------------------|-------------------------|
| **Project Duration** | 23/06/2026 - 03/07/2026 |
| **Presentation Date**| 03/07/2026              |
| **Late Submission**  | -1                      |
| **Requirements**     | Git repo + Slide        |
| **Document**         | Tasks division          |

## Packages for API Server

```sh
dotnet add package NSwag.AspNetCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package  Microsoft.EntityFrameworkCore.Tools
```

## Add migrations

```sh
dotnet ef migrations add "InitCreate"
```

## Installation
API Installation instructions:

```sh
cd PortalApi
dotnet ef database update
```

## Creating API Controller

```sh
dotnet aspnet-codegenerator controller -api -async -outDir Controllers -m YOUR_MODEL -dc PortalContext -dbProvider sqlite -name YOUR_CONTROLLER_NAME

dotnet aspnet-codegenerator controller -api -async -outDir Controllers -m User -dc PortalContext -dbProvider sqlite -name UsersController
```