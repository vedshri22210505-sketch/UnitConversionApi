# Unit Conversion API

A RESTful ASP.NET Core Web API for converting values between different measurement units.

## Supported Categories

### Length
- meter
- kilometer
- feet
- inch

### Weight
- kilogram
- gram
- pound

### Temperature
- celsius
- fahrenheit
- kelvin

## Run Locally

1. Clone the repository

```bash
git clone <repository-url>
```

2. Navigate to the project folder

```bash
cd UnitConversionApi
```

3. Restore dependencies

```bash
dotnet restore
```

4. Run the application

```bash
dotnet run
```

5. Open Swagger

https://localhost:7220/swagger

## Design Decisions

- Conversion logic is separated into a service layer.
- Units are stored in centralized dictionaries.
- Swagger is used for API documentation and testing.