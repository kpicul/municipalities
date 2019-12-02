# municipalities
This is a client for municipalities server. It opens a weebpage for selecting pages from database in dropdown menu.

## Requirements
* .NET Framework 4.7.2
* Newtonsoft.json
* HttpClient

## Setting up 
* First run the server from https://github.com/kpicul/municipalityServer and then run this project. 
Project will run on https://localhost:44314/

## Description
* In Controllers/HomeController.cs is a mvc controller for the get request4
* Municipality.cs and MunicipalityList.cs are objects for parsing the json response
* Index.cshtml is a webpage that runs on start
