## ParkingPermitService 

Name - Sahil Halwawala
Student Number - 8909493

This project is done in the MACBOOK and so used vs code 

## Description
This is assignment 1 for the subject DISTRIBUTED APPLICATIONS DEVELOPMENT in which we have build a ASP.NET Web API core for the parking permit service with all the proper validation of data and all used the github control source to check the progress of the project. Along with this the database that is used is sqlite and created migration using CLI and then registered the appbd context in the program.cs, here, the appdbcontext is manually created and then in the appsettings.json the connection is set to permits.db which has the data of the parking service 

## Domain Model: StudentParkingPermit
- Id (int)
- StudentEmail (string) [Required, EmailAddress]
- PlateNumber (string) [Required, StringLength]
- PermitType (string) [Required]
- ExpiryDate (DateTime) [Required]

## To Run this - Use the given command in line 
1. Restore packages:
   - `dotnet restore` - helps to restore all the packages
2. Apply database migration:
   - `dotnet ef database update` - updates the downlaod package and then set of the default one
3. Run the service:
   - `dotnet run` - runs the application
4. Open Swagger:
   - `http://localhost:PORT/swagger` - For me the ports were 5270 

## Notes
- Database file: `permits.db`
- Base route: `/api/StudentParkingPermits` - manually declared 

## Git Hub Repo link - https://github.com/SahilHalwawala/ParkingPermitServiceWebAPICore

## Why i used this model 
I chose the Student Parking Permit microservice because it models a real-world university use case, avoids common textbook examples, and clearly demonstrates CRUD functionality, data validation, and persistence using Entity Framework Core. It also aligns well with microservice principles by focusing on a single responsibility within a larger campus management system.