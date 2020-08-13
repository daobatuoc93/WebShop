# ASP.NET Core 3.1 Web Shop Projects
## Technologies
- ASP.NET Core 3.1
- Entity Framework Core 3.1
## Install Tools
- .NET Core SDK 3.1
- Git client
- Visual Studio 2019
- SQL Server 2019
##  tutorial
- https://docs.microsoft.com/en-us/ef/core/
- https://www.learnentityframeworkcore.com/
## How to configure and run
- Clone code from Github: git clone https://github.com/daobatuoc93/WebShop.git
- Open solution eShopSolution.sln in Visual Studio 2019
- Set startup project is eShopSolution.Data
- Change connection string in Appsetting.json in eShopSolution.Data project
- Open Tools --> Nuget Package Manager -->  Package Manager Console in Visual Studio
- Run Update-database and Enter.
- After migrate database successful, set Startup Project is eShopSolution.WebApp
- Change database connection in appsettings.Development.json in eShopSolution.WebApp project.
- Choose profile to run or press F5
#
# Learning Details
#
## Create Web Solution
- Create web solution and source code repository
- Create Solution structure
## Design system functions and Database
- Download and Install EntityFrameworkCore(3.1x)
- =====================Design(3.1x)
- =====================SqlServer(3.1x)
- =====================Tools(3.1x)
- Create EF folder
- Create properties and setting key for these entities 
- Create WebshopDbContext and Creat WebShopContextFactories
## Create Entity Classes and Set up EF core
- Create Entity Folder and Set up Ef core
- Create Entity Class based on Entity set up before
## Config Entity with Fluent API 
- Config Entities with fluent api via IEntityTypeConfiguration
- Create Configuration Folder and Config 
- Add it on Dbcontext with new Configurations
## Migration with our config
- Create InitialWebShop Migration to SqlServer
## Create Template Recording Data with DATA SEEDING
- Refer Dataseeding in tutor and move to EF core DATASEEDING.
- Create Extensions with ModelBuilderExtensions with Record Data
- Add modelBuilder.Seed() to DbContext and Add-Migation NewDataSeeding 
## Adding Identity Table 
- Refer to Sercurity and Identity in EFCore 3.1x
- Purpose:authentication and authorization
- Create IdentityDbContext<AppUsers,AppRoles,Key(guid recommend)>
- Create class AppUser : IdentityUser<Guid>
- Create class AppRole : IdentityRole<Guid>
- Configure AppRoleConfiguration and AppUserConfiguration : IEntityTypeConfiguration<AppRole>
- make sure that we need to add it on OnmodelCreating
- Create Key for Configuration Appuser,AppRoles related to about Cart,Transactions...
- Creat Data Seeding User to Database, Create two Data : Entity<AppUser>,Entity<AppRole>
and Seeding the relation between our user and role to AspNetUserRoles table