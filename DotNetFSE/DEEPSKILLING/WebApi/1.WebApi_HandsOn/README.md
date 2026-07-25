# Web API Hands-on 1

## Objective

This hands-on demonstrates the creation of a simple ASP.NET Core Web API application with CRUD (Read/Write) action methods. It explains the basics of RESTful Web APIs, HTTP request/response, action verbs, and configuration files.

The objectives covered in this hands-on are: RESTful Web Services, Web API & Microservices, REST architecture, HTTP Request & Response, HTTP Action Verbs (GET, POST, PUT, DELETE), HTTP Status Codes, Web API project structure, and configuration files. :contentReference[oaicite:0]{index=0}

---

# Technologies Used

- ASP.NET Core Web API
- C#
- .NET 10
- Visual Studio 2022
- Swagger (Swashbuckle.AspNetCore)

---

# Project Structure

```
1.WebApi_HandsOn
│
├── Controllers
│   ├── ValuesController.cs
│   └── WeatherForecastController.cs
│
├── Properties
│   └── launchSettings.json
│
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
├── WeatherForecast.cs
└── 1.WebApi_HandsOn.csproj
```

---

# Steps Performed

## Step 1

Created a new **ASP.NET Core Web API** project using Visual Studio 2022.

---

## Step 2

Selected

- ASP.NET Core Web API Template
- Authentication: None
- Controllers Enabled

---

## Step 3

Added a controller with Read/Write action methods.

Controller:

```
ValuesController
```

Generated methods:

- GET
- GET By Id
- POST
- PUT
- DELETE

---

## Step 4

Installed Swagger support using NuGet.

Package installed:

```
Swashbuckle.AspNetCore
```

---

## Step 5

Configured Swagger inside **Program.cs**.

Added:

```csharp
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
```

Configured middleware:

```csharp
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
```

---

## Step 6

Executed the project.

Application started successfully.

Server URLs:

```
https://localhost:7052
http://localhost:5110
```

---

## Step 7

Opened Swagger UI.

```
https://localhost:7052/swagger
```

---

## Step 8

Executed the GET endpoint.

Endpoint:

```
GET /api/Values
```

Response:

```json
[
  "value1",
  "value2"
]
```

Status Code:

```
200 OK
```

---

# HTTP Methods Used

| Method | Description |
|---------|-------------|
| GET | Retrieve data |
| POST | Create new data |
| PUT | Update existing data |
| DELETE | Delete data |

---

# HTTP Status Code

| Status Code | Meaning |
|-------------|---------|
| 200 OK | Request executed successfully |

---

# Configuration Files

## Program.cs

Configures:

- Dependency Injection
- Middleware
- Routing
- Swagger
- Controller Mapping

### appsettings.json

Stores application configuration.

### launchSettings.json

Stores launch profiles and application URLs.

---

# API Tested

### GET

```
/api/Values
```

Response

```json
[
  "value1",
  "value2"
]
```

Status

```
200 OK
```

---

# Learning Outcomes

After completing this hands-on, the following concepts were understood:

- RESTful Web API
- ASP.NET Core Web API
- HTTP Request and Response
- HTTP Action Verbs
- Controller
- Action Methods
- Routing
- Swagger UI
- OpenAPI
- Program.cs configuration
- appsettings.json
- launchSettings.json

---

# Result

Successfully created and executed an ASP.NET Core Web API application.

Verified the API using Swagger UI and successfully tested the GET endpoint, receiving a **200 OK** response with sample data, meeting the objectives of the hands-on. :contentReference[oaicite:1]{index=1}
