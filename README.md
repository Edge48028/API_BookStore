<!DOCTYPE html>
<html>
<body>
<h2 align="center">🛠 Technologies and Tools 🛠</h2>
<br>
<!-- https://simpleicons.org/ -->
<span><img src="https://img.shields.io/badge/ASP.NET-282C34?logo=dotnet&logoColor=#512BD4" alt="ASP.NETlogo" title="ASP.NET" height="25" /></span>
&nbsp;
<span><img src="https://img.shields.io/badge/Visual Studio-282C34?logo=visualstudio&logoColor=#5C2D91" alt="Visual Studio logo" title="Visual Studio" height="25" /></span>
&nbsp;
<span><img src="https://img.shields.io/badge/MicrosoftSQLServer-282C34?logo=microsoftsqlserver&logoColor=#CC2927" alt="Microsoft SQL Server logo" title="Microsoft SQl Server" height="25" /></span>
&nbsp;
<span><img src="https://img.shields.io/badge/PostMan-282C34?logo=postman&logoColor=#FF6C37" alt="PostMan logo" title="PostMan" height="25" /></span>
&nbsp;
<span><img src="https://img.shields.io/badge/JWT-282C34?logo=jsonwebtokens&logoColor=#000000" alt="JWT logo" title="JWT" height="25" /></span>
&nbsp;
<span><img src="https://img.shields.io/badge/git-282C34?logo=git&logoColor=#F05032" alt="git logo" title="git" height="25" /></span>
&nbsp;
<span><img src="https://img.shields.io/badge/GitHub-282C34?logo=github&logoColor=#181717" alt="GitHub logo" title="GitHub" height="25" /></span>
<br>
<h1>Web API .NET Core 7.0</h1>

<p>It's a versatile ASP.NET Core 7.0 application with integrated authentication and authorization, user account management, and book information management. The application uses Entity Framework Core to connect and manage a SQL Server database.</p>

<h2>Main Features</h2>

<h3>Authentication and Authorization</h3>

<ul>
    <li>Integrated authentication and authorization using Identity Framework and JSON Web Tokens (JWT) for security.</li>
    <li>User account management with registration and login capabilities.</li>
</ul>

<h3>User Role Management</h3>

<ul>
    <li>Implements role-based authorization with two main roles: "User" and "Admin."</li>
</ul>

<h3>Book Management (Books)</h3>

<ul>
    <li>Provides API for basic operations on book information, including create, update, list, view details, and delete. These operations require "Admin" role permissions.</li>
</ul>

<h3>Auto-Mapping with AutoMapper</h3>

<ul>
    <li>Utilizes the AutoMapper library to map between Data Transfer Object (DTO) objects and database objects.</li>
</ul>

<h3>Repository</h3>

<ul>
    <li>Creates a repository (IBookRepository) to abstract database operations.</li>
</ul>

<h3>Customized Swagger</h3>

<ul>
    <li>Integrates Swagger to automatically generate API documentation and provide a user-friendly interface for API testing.</li>
</ul>

<h3>Display Roles on Swagger UI</h3>

<ul>
    <li>Customizes the Swagger interface to display the roles of logged-in users.</li>
</ul>

<h3>Error Handling</h3>

<ul>
    <li>Customizes the API to provide informative error messages when users attempt unauthorized actions due to permissions.</li>
</ul>

<h2>How to Use</h2>

<ol>
    <li>Clone the project from GitHub to your local machine.</li>
    <li>Open the project in Visual Studio or your favorite code editor.</li>
    <li>Install NuGet packages by running the `dotnet restore` command in the project's root folder.</li>
    <li>Set up the database connection string in the `appsettings.json` file and run the SQL Server database.</li>
    <li>Run the project and test the API through the Swagger interface.</li>
</ol>

<h2>Improvement and Development</h2>

<p>
    With the foundation in place, you can develop the application further according to your needs. Here are some ideas:
</p>

<ul>
    <li>Add additional features for book management, such as searching, sorting, and filtering.</li>
    <li>Enhance security integration by adding two-factor authentication (2FA) or JWT-based authentication.</li>
</ul>

<h2>Documentation</h2>

<p>
    This project is built based on knowledge and guidance from <a href="https://docs.microsoft.com/en-us/aspnet/core">Microsoft Docs</a>.
</p>

<p>
    If you want to log in please use the following accounts:

    - username : user, password : 1 (role user)

    - username : admin, password : 1 (role admin)

    - username : sales, password : 1 (sales role)
</p>

<p>
Access: http://localhost:5000/swagger/index.html
Or public for others to use via IPv4 connection: http://<IPv4>:5000/swagger/index.html
</p>
    
<h2>Author</h2>

<p>
    - [Hoàng]
    - [[Link to my GitHub profile](https://github.com/Edge48028)]
</p>

</body>
</html>
