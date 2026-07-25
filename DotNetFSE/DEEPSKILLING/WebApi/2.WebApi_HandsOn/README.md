# Web API Hands-on 2

## Objective

This hands-on demonstrates how to integrate Swagger with an ASP.NET Core Web API application and use Postman to test REST API endpoints. It also covers route customization using Route attributes.

The objectives include:

- Install Swashbuckle.AspNetCore
- Configure Swagger
- Display API documentation in the browser
- Test APIs using Postman
- Modify controller routes
- Verify API responses and HTTP status codes

---

# Technologies Used

- ASP.NET Core Web API
- C#
- .NET 10
- Visual Studio 2022
- Swagger (Swashbuckle.AspNetCore)
- Postman

---

# Project Structure

```
2.WebApi_HandsOn
│
├── Controllers
│   └── WeatherForecastController.cs
│
├── Program.cs
├── WeatherForecast.cs
├── appsettings.json
├── appsettings.Development.json
└── Properties
    └── launchSettings.json
```

---

# Package Installed

NuGet Package

```
Swashbuckle.AspNetCore
```

Purpose

- Generates OpenAPI documentation.
- Provides Swagger UI.
- Allows testing APIs directly from the browser.

---

# Program.cs Configuration

Added Swagger services.

```csharp
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
```

Configured middleware.

```csharp
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Demo");
    });
}
```

---

# Controller Route Modification

Original Route

```csharp
[Route("[controller]")]
```

Modified Route

```csharp
[Route("api/Emp")]
```

This changes the API endpoint from

```
/WeatherForecast
```

to

```
/api/Emp
```

---

# Running the Application

Run the project using Visual Studio.

Application URLs

```
https://localhost:7139
http://localhost:5032
```

---

# Swagger Testing

Open

```
https://localhost:7139/swagger
```

Swagger UI displays all available API endpoints.

Executed

```
GET /api/Emp
```

Response Status

```
200 OK
```

---

# Postman Testing

Method

```
GET
```

URL

```
https://localhost:7139/api/Emp
```

Response

```json
[
  {
    "date": "2026-07-27",
    "temperatureC": 45,
    "temperatureF": 112,
    "summary": "Scorching"
  },
  {
    "date": "2026-07-28",
    "temperatureC": 7,
    "temperatureF": 44,
    "summary": "Bracing"
  }
]
```

Status

```
200 OK
```

---

# HTTP Method Used

| Method | Purpose |
|---------|---------|
| GET | Retrieve weather forecast data |

---

# HTTP Status Code

| Status | Meaning |
|--------|---------|
| 200 OK | Request completed successfully |

---

# Features Demonstrated

- ASP.NET Core Web API
- Swagger Integration
- Swagger UI
- API Documentation
- Route Attribute
- HTTP GET Request
- JSON Response
- Postman API Testing
- RESTful Web Services

---

# Learning Outcomes

After completing this hands-on, I learned to:

- Install Swagger using Swashbuckle.AspNetCore.
- Configure Swagger services in Program.cs.
- Generate API documentation.
- Execute APIs using Swagger UI.
- Test APIs using Postman.
- Modify controller routes using the Route attribute.
- Verify API responses and HTTP status codes.

---

# Result

Successfully created an ASP.NET Core Web API project, integrated Swagger, verified API documentation, tested REST endpoints using Swagger UI and Postman, modified the controller route to `api/Emp`, and confirmed successful execution with HTTP 200 OK responses.
