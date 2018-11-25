# TechnicalTest

File Layout for Technical Test:
Controllers -> MembersController.cs
Models -> Members.cs

How to build and run the application:
Open the application on Microsoft Visual Studio and press run.
A browser window will open with a default ASP.NET page.
Enter this URL "http://localhost:49916/api/members" into the browser to return a list of all Member resources.

Enter these URL into the browser to return a Member resource for a given unique memberNumber:
- "http://localhost:49916/api/members/1234567890"
- "http://localhost:49916/api/members/1"
- "http://localhost:49916/api/members/2"

When the application is running, you can also use the Postman application to test the running application. Postman is used for performing integration testing and simulating how the user might interact with the system.

This application is created for demonstration purposes, instead of hardcoding the application and using a database to store the properties, it will reduce the complexity of the system and will be much easier to update/delete its properties.
