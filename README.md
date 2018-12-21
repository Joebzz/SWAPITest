# Kneat Software Test
The Kneat software test uses the [SWAPI (The Star Wars API)](https://swapi.co).

## Test Requirements
For all SW star ships, to cover a given distance, how many stops for resupply are required.

The application will take as input a distance in mega lights (MGLT).
The output should be a collection of all the star ships and the total amount of stops required to make the distance between the planets.

## Description
The Solution contains 3 projects.
1. KneatAssignment - The console application project, does the calculations required for this Test
2. SWAPIHelper - A helper class library for the SWAPI, contains the definitions for the entities that are returned by the API and does the requests to the API
3. KneatAssignment.Test - Unit tests for the solution

## Prerequisites
* Visual Studio 2017 or higher
* .Net Version 4.5.2

## Installation
* Clone this repository
* Open the solution in Visual Studio
* Make sure that the KneatAssignment project is set as the Startup project

## Usage
* Run the program in Visual Studio
* The application will ask for the distance in Mega Lights (MGLT) this must be numeric
* The result of the calculated ammount of stops for each ship will be returned
* You can then enter a different distance or press 'q' to cancel

## Unit Tests
There are 5 Unit Tests written for this project.
1. GetAllStarshipsTest() - Tests that there is a result returned from the API for the request for all starships
2. GetAllStarshipsTestStarship() - Checks that the one of the returned items in the list is a Starship object
3. GetStopsRequired_TestForYwing() - As the value for the Y-Wing was provided for an input of 1000000 MGLT this value is used to test the calculation functions
4. GetStopsRequired_TestForFalcon() - As the value for the Falcon was provided for an input of 1000000 MGLT this value is used to test the calculation functions
5. GetStopsRequired_TestForRebelTransport() - As the value for the Rebel Transport was provided for an input of 1000000 MGLT this value is used to test the calculation functions

The tests can be run by clicking 'Test' -> 'Run' -> 'All Tests'

## NuGet Packages Used
* Refit (https://github.com/reactiveui/refit)- An automatic type-safe REST library for .NET, Refit allows you to define an interface for an API that your application wants to call and using that it hides all the HTTP and JSON serialization/deserialization bits.
* NLog (https://nlog-project.org/) - Used to create log files of the output and any exceptions that are thrown.