# ABPMySqlEFIssueDemo
Showcase of the issue with ABP and EF to MySql

## Steps to reproduce the issue with this project
1. Install MySql (the issue is tested with version 5.7, unclear if others are affected)
2. Clone or download the repo
3. Run update-database command from package manager console to deploy the model to MySql
4. Set the web project as the startup project
5. Launch the application
6. Click the home button on the side menu
   * This will fire a call to the CarAppService which will log to the console if successful
   * It should break at line 27 of the CarAppService

## Steps taken to create this project
1. Download a new ABP ASP.NET MVC 5.x AngularJS Template
2. Install MySql.Data.Entity v 6.9.11 from nuget
3. Update connection string to use mysql provider
4. Added CustomMySqlMigrationSqlGenerator to properly handle migrations
5. Reference CustomMySqlMigrationSqlGenerator in Migrations.Configuration
6. Added models for Make, Model, Car that all used the FullAuditedEntity base class
7. Added seeds to populate Make, Model, Car and an AppService to get cars
8. Call the get cars method on page load on the home page
