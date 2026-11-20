Unit Conversion API
Description

A RESTful ASP.NET Core Web API for converting values between different units of measurement.

Supported categories:

Length
Weight
Temperature
Endpoints
Convert Units
POST /api/Conversion

Get Supported Units
GET /api/Conversion/units

Architecture
Controller -> Service -> Repository -> In-Memory Data

Design Decisions
Repository Pattern used to separate business logic from data access.
Service Layer contains conversion logic.
Dependency Injection used throughout the application.
Global Exception Middleware used for centralized error handling.
Conversion data is hardcoded as per assessment requirements.
Run Locally
Prerequisites:

.NET 8 SDK
Visual Studio 2026
Run:

dotnet restore

dotnet run

Run Tests
dotnet test