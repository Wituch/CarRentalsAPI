# CarRentalsAPI

Repository containing source code of API for car rentals created as part of recrutation process for Jetshop.

# Testing the solution in cloud
The solution has been deployed to Microsoft Azure, where it can be tested without any prior configuration. Visit: 
http://carrentalsapi.azurewebsites.net/

# Running the solution on local machine
## Prerequisites
* Visual Studio 2019
* .NET Core 3.1 SDK
* SQL Server Express LocalDB (default db used for development)

## How to run the solution
* Download the source code and open CarRentalsAPI solution in VS
* Make sure the solution is loaded properly and can be compiled
* Configure database by either:
  * Using default db options and setting up LocalDB
  * Using db of your choice and changing connection string in appsettings.json accordingly
* Create database using CodeFirst approach for EF Core eg. by running Update-Database command in VS Package Manager Console
* Make sure database update finished succesfuly and tables with data has been created (by e.g. checking using SQL Server Managment Studio)
* Run the solution in VS on e.g. local IIS
* Swagger UI page for solution should appear in web browser

