# Skola24-worksample
This is a worksample for Skola24.
For convinence both backend and frontend have been placed on same repo.

The backend consists of a CORE REST API (OpenApi 7.0.11) coupled with Entity Frameworks (7.0.14) code first sql database.

Frontend is built upon Vue.js (v3.3.4)

A simple github workflow is running a build and test flow each time a pr or push is made to the main- or development branch.

---
## Installation
Clone the repository.


## - Backend
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

## - Frontend
It is easiest to load the frontend solution in Visual Studio Code. 
- File -> Open Folder -> Frontend (Mark folder and click open)

After opened folder. Run following command in terminal:
* `npm install`
* `npm run build`

#### Vue.js features
* **Axios**: Axios setup for enabling API endpoint access.
* **Router**: Vue-router for multipage navigation
* **Bootstrap-icons**: Access icons via bootstrap
* **CSS-grid**: A simple css-grid made for easy and fast layouting

---
## Running solution
Both Frontend and API can be run separately but in frontend one part ("Frånvarokollen") use the API exclusively. For full experience it's recommendend to run both solutions simultaneously.
* API - Start via Visual studio **https**. A new browser window with **Swagger** should open with the url https://localhost:7285
* Vjue - In terminal run **`npm run dev`** (start client server) Open a new browser and type in url **http://localhost:5173/**

Now you should be up and running the full solution

---
## Testing
Since the much of the seed-data is randomly generated each time you create the database from a newly cloned repo, different data will be added each time. So there is no telling when testing out the endpoints e.g how many students a particular school contains. But each School should contain at least 1 student.
The only constant data is School names (names generated).

So to test the endponts in Swagger and Frontend ("Frånvarokollen")
Here's a list of all schools created each time so you don't have to go into SQL Mangagement Studio to have a lookup:

Ängelholmsgymnasiet<br>
Bromma gymnasium<br>
Centralgymnasiet<br>
Eriksdalsskolan<br>
Falkenbergsskolan<br>
Göteborgs högre samskola<br>
Hässelbygårdsskolan<br>
Hästhagenskolan<br>
Högdalsskolan<br>
Hudiksvalls högstadieskola<br>
Kristianstadsgymnasiet<br>
Kungsängsgymnasiet<br>
Lindeskolan<br>
Mälarhöjdens skola<br>
Malmö Borgarskola<br>
Mölndals högstadieskola<br>
Nordvästra skolan<br>
Nynäshamnsskolan<br>
Örebrogymnasiet<br>
Österänggymnasiet<br>
Östra grundskolan<br>
Sjöbergsskolan<br>
Skarpängsskolan<br>
Söderskolan<br>
Södertälje gymnasium<br>
Sturegymnasiet<br>
Sunnegårdsskolan<br>
Sveagymnasiet<br>
Västergårdsskolan<br>
Västermalms högstadieskola<br>
