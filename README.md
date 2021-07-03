# National Parks API

#### Epicodus Code Review: Web APIs

#### By Shannon Lee

#### _Table of Contents_

1. [Description](#description)
2. [Technologies Used](#technologies)
3. [Setup/Installation Requirements](#setup)
4. [Endpoints](#endpoints)
5. [Known Bugs](#bugs)
6. [License](#license)
7. [Contact Information](#contact)


## Description <a id="description"></a>

This is a web API made using C#, .NET5, MySQL, and Entity that contains a database for U.S. National Parks. It makes use of Swagger UI to provide documentation for the endpoints. 

## Technologies Used <a id="technologies"></a>

* C#
* .NET 5
* MSBuild
* MSTest
* Entity
* Swagger
* MySQL
* git


## Setup/Installation Requirements <a id="setup"></a>

Setup requirements
* Make sure that .NET Software Development Kit 5 and MySQL have been installed to your local machine.

Installation
* Clone this repository to your machine `$ git clone https://github.com/shanole/NationalParksApi.Solution`
* In the terminal, navigate to the project directory `$ cd NationalParksApi`
* Create `appsettings.json` file in `/NationalParksApi` directory with the following code:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=shannon_lee;uid=root;pwd=<YOUR PASSWORD HERE>;"
  }
}
```
* Create local database from migration with `dotnet ef database update`
* Compile code by running command `$ dotnet build`
* Run server with command `$ dotnet run` 
* Navigate to desired endpoint as documented below

## Endpoints <a id="endpoints"></a>

To see Swagger documentation, click [here](http://localhost:5000/swagger)

**GET requests**
* `http://localhost:5000/api/nationalparks/parks`
  * GETs all National Parks in the database. The database is seeded with information from 2 National Parks, Mount Rainer and Zion.

*`http://localhost:5000/api/nationalparks/parks?name=<YOUR QUERY HERE>`
  * GETs any National Parks with a name that matches your query

*`http://localhost:5000/api/nationalparks/parks?location=<YOUR QUERY HERE>`
  * GETs any National Parks with a location that matches your query

*`http://localhost:5000/api/nationalparks/parks?description=<YOUR QUERY HERE>`
  * GETs any National Parks that have a description containing your query

*`http://localhost:5000/api/nationalparks/parks/{ID}`
  * GETs the National Park with the Id as specified in the request

**POST**
* `http://localhost:5000/api/nationalparks/parks`
  * POSTs a new National Park to the API

**DELETE**
* `http://localhost:5000/api/nationalparks/parks/{ID}`
  * DELETEs the National Park with the Id as specified in the request

**PUT**
* `http://localhost:5000/api/nationalparks/parks/{ID}`
  * PUTs new data into the National Park entry with the Id as specified in the request

## Known Bugs <a id="bugs"></a>
* None known at this time. If you find one, please don't hesitate to contact me about it!

## License <a id="license"></a>
*[MIT](https://choosealicense.com/licenses/mit/)*

Copyright (c) 2021 Shannon Lee

## Contact Information <a id="contact"></a>
**_Shannon Lee [mailto](mailto:shannonleehj@gmail.com)_**