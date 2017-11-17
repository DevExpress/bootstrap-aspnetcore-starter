# DevExpress ASP.NET Core Bootstrap starter project
 
This project demonstrates how to use our new set of controls for the new ASP.NET Core 2.0 framework, which we have recently [announced](https://community.devexpress.com/blogs/aspnet/archive/2017/10/10/new-bootstrap-controls-for-asp-net-core-2-0-ctp-release-join-the-pre-release-party.aspx). This project contains a simple Registration form and GridView that supports data editing. You can use the project to get started with your next ASP.NET Core project (see *A Boilerplate-only Option* for details). All required DevExpress references are already included. 
 
There's also [a docker image](https://hub.docker.com/r/devexpress/bootstrap-aspnetcore-starter) that contains this project running on Ubuntu!
 
 
## Getting Started
1. Download and install [.NET Core 2.0 SDK](https://www.microsoft.com/net/download/core).
2. Clone the demo project. 
3. Open the project's root folder.
4. Open Console and type the following commands in it:
   - `dotnet restore`
   - `dotnet run`
5. Open the NuGet.config file:
```XML
<?xml version="1.0" encoding="UTF-8"?>
<configuration>
    <packageSources>
        <add key="DevExpress" value="https://nuget.devexpress.com/[your_devexpress_authorization_key]/api/" />
    </packageSources>
</configuration>
```
replace the `[your_devexpress_authorization_key]` section with your [DevExpress NuGet](https://www.devexpress.com/Support/Center/Question/Details/T466415/devexpress-nuget-packages) feed authorization key that you can find in the [Download Manager](https://www.devexpress.com/ClientCenter/DownloadManager/).
 
## Run in Docker 
1. [Get Docker](https://docs.docker.com/engine/installation/)
2. Clone the demo project.
3. Add your [DevExpress NuGet](https://www.devexpress.com/Support/Center/Question/Details/T466415/devexpress-nuget-packages) feed authorization key. See #5 in the [Getting Started](#getting-started) section above. 
4. Bind your Docker account to your GitHub account. See [this document](https://docs.docker.com/docker-hub/github/#linking-docker-hub-to-a-github-account) for details.
5. Create an [Automated build](https://docs.docker.com/docker-hub/builds/#create-an-automated-build) with the "bootstrap-aspnetcore-starter" name.
6. After the application is successfully built, run a local Docker image using the following command:
`docker run --rm -ti -p 5000:5000 [yuor_docker_account]/bootstrap-aspnetcore-starter`
replace the `[your_docker_account]` section with your own Docker account name. 
3. Navigate to http://localhost:5000
 
## A Boilerplate-only Option 
If you would prefer to delete sample data from this project, remove the following files and folders: `Controllers/SampleController.cs`, `Data`, `Models/NorthwindContext.cs`, `Models/Person.cs`, `Views/Sample`.
 
## Online demos 
Visit our [ASP.NET Core Bootstrap demos](https://demos.devexpress.com/aspnetcore-bootstrap) to see what components are already available. Use them in the attached sample project to see how they work on your side. 
 
## Provide feedback 
Please provide us with feedback via the [DevExpress Support Center](https://www.devexpress.com/Support/Center/Question/Create).
 
