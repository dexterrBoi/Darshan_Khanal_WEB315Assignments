# Darshan_Khanal_WEB315Assignments
 Assignment
Creates a Razor WebApp Project:
dotnet new webapp -o RazorPagesDcUniverse
code -r RazorPagesDcUniverse

Install the EF Tools and NuGet packages:
dotnet tool install --global dotnet-ef --version 5.*
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

Scaffolding terminal commands to build out your CRUD pages for model:

dotnet-aspnet-codegenerator razorpage -m Movie -dc RazorPagesDcUniverseContext -udl -outDir Pages/Movies --referenceScriptLibraries -sqlite

Entity Framework Migration feature:
dotnet ef migrations add InitialCreate
dotnet ef database update
