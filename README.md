# Registration API

## Description
This API provides functionality for registering subjects, students, and exams. It follows a RESTful architecture and includes standard practices for request and error handling.

## Technologies
- **ASP.NET Core**: the primary framework for building web applications.
- **Entity Framework Core**: ORM for interacting with a local database.
- **FluentValidation**: for validating input data.
- **ProblemDetails**: standard way to represent errors in JSON format.

## Architecture
The application is structured in a three-layer architecture:
1. **Presentation Layer**: handles HTTP requests and responses.
2. **Application Layer**: contains business logic and interacts with the data layer.
3. **Data Layer**: responsible for database interactions via Entity Framework.

## Installation
1. Clone the repository:
   ```bash
   git clone <repository link>
2. Install dependencies:
   ```bash
   dotnet restore
3. Run the application:
   ```bash
   dotnet run
4. Change the connection string if necessary in the appsettings file.
5. Apply the migrations.
   ```bash
   add-migration <migration_name>
6. Update database
   ```bash
   update-database
## Endpoints
1. POST /api/Registration/subjects: register a subject.
2. POST /api/Registration/students: register a student.
3. POST /api/Registration/exams: register an exam.
## Logging
All errors are handled by a global exception handler, and information about them is logged.
