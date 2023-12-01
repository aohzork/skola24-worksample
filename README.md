# Skola24-worksample
This is a worksample for Skola24.

For convinience this repo contains an API and a Frontend instead of two separate repos.
**API**: Is a CORE REST API coupled with Entity Frameworks code first sql database.
**Frontend**: Vue.js with routercapabilities and access to API.


# Installation
Clone the repository and follow instructions below.

## API

### - Database
* **To create the database**: In Visual Studio in Package Manager Console. Default project set to: API.<br>
Apply the migrations and create the database by running the command '`update-database`'.<br>
This will create a local database to access via SQL Server Management Studio.

* **To Access the database:** Connect *Database Engine* with *Windows Authentication* and *Server name:* `(localdb)\MSSQLLocalDB`

#### Database features
* **Seeding**: The database is set to seed some amount of initial data using the methods in `SeedHelper.cs` <br>
when creating the database for the first time.
* **Dynamic connectionstrings**: When working in local environment, a connectionstring is used to access the local database created. <br>
When in production a different connectionstring will be used automatically.
* **Stored procedure**: When first time creating the database a stored procedure called `GetAbsenceBySchool` is created which is used<br>
in AbsenceService as well as can be tested inside SQL Management Studio.
* **Cors**: Cors is configured for localhost for Vue to be able to access the API.

##### Troubleshooting
* **Cannot find Stored Procedure in SQL Management Studio**: If you can see the stored procedure inside *Database (LocalSkola24) -> Programmability -> Stored Procedures* (`db.GetAbsenceBySchool)`, then refresh Intellisence Cache with `CTRL+SHIFT+R`.


## Vue.js
