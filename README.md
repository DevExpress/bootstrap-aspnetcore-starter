# DevExpress ASP.NET Core Bootstrap starter project
 
This project demonstrates how to use our new set of controls for the new ASP.NET Core 2.0 framework, which we have recently [announced](https://community.devexpress.com/blogs/aspnet/archive/2017/09/26/new-bootstrap-controls-for-asp-net-core-2-0-alpha-release-will-you-help-us-test-them-please.aspx). This project contains a simple Registration form and GridView that supports data editing. You can use the project to get started with your next ASP.NET Core project (see *A Boilerplate-only Option* for details). All required DevExpress references are already included. 
 
There's also [a docker image](https://hub.docker.com/r/devexpress/bootstrap-aspnetcore-starter) that contains this project running on Ubuntu!
 
 
## Getting Started
1. Download and install [.NET Core 2.0 SDK](https://www.microsoft.com/net/download/core).
2. Download the demo project. 
3. Open the project's root folder.
4. Open Console and type the following commands in it:
   - dotnet restore
   - dotnet run
 
## Run in Docker 
1. [Get Docker](https://docs.docker.com/engine/installation/)
2. docker run --rm -ti -p 5000:5000 devexpress/bootstrap-aspnetcore-starter
3. Navigate to http://localhost:5000
 
## A Boilerplate-only Option 
If you would prefer to delete sample data from this project, remove the following files and folders: `Controllers/SampleController.cs`, `Data`, `Models/NorthwindContext.cs`, `Models/Person.cs`, `Views/Sample`.
 
## Online demos 
Visit our [ASP.NET Core Bootstrap demos](https://demos.devexpress.com/aspnetcore-bootstrap) to see what components are already available. Use them in the attached sample project to see how they work on your side. 
 
## Provide feedback 
Please provide us with feedback via the [DevExpress Support Center](https://www.devexpress.com/Support/Center/Question/Create).
 
