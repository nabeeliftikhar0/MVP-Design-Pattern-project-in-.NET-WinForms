# Multi-Tenant .NET Console Application

A .NET console application demonstrating the implementation of a multi-tenant system using the Model-View-Presenter (MVP) design pattern. The application connects to a mock API (JSONPlaceholder) and simulates tenant-specific data retrieval.

## Project Structure

```
MultiTenantApp.Console/
├── Model/
│   ├── TenantData.cs           # Data model for tenant information
│   ├── ITenantApiService.cs    # API service interface
│   └── TenantApiService.cs     # API service implementation
├── View/
│   ├── ITenantView.cs          # View interface
│   └── ConsoleTenantView.cs    # Console-based view implementation
├── Presenter/
│   └── TenantPresenter.cs      # Business logic coordinator
└── Program.cs                  # Application entry point
```

## Features

- **MVP Architecture**
  - Clear separation of concerns
  - Interface-driven design
  - Testable components
  
- **Multi-tenant Support**
  - Tenant identification via headers
  - Tenant-specific data retrieval
  - Error handling for invalid tenants

- **API Integration**
  - Async HTTP communication
  - JSON deserialization
  - Error handling and logging

- **User Interface**
  - Interactive console interface
  - Formatted data display
  - Error message highlighting

## Prerequisites

- .NET 8.0 or later
- Visual Studio 2022, VS Code, or any .NET-compatible IDE
- Internet connection (for API access)

## Getting Started

1. Clone the repository:
```bash
git clone [repository-url]
```

2. Navigate to the project directory:
```bash
cd MultiTenantApp.Console
```

3. Restore NuGet packages:
```bash
dotnet restore
```

4. Build the application:
```bash
dotnet build
```

5. Run the application:
```bash
dotnet run
```

## Usage

1. When prompted, enter a tenant ID (any number between 1-10)
2. The application will retrieve posts associated with that tenant
3. Data will be displayed in a formatted view
4. Press any key to exit

## Implementation Details

### Model Layer
- `TenantData`: Represents the data structure for tenant information
- `ITenantApiService`: Defines the contract for API communication
- `TenantApiService`: Implements API communication with JSONPlaceholder

### View Layer
- `ITenantView`: Defines the user interface contract
- `ConsoleTenantView`: Implements console-based user interaction

### Presenter Layer
- `TenantPresenter`: Coordinates between Model and View
- Handles business logic and error management
- Manages data flow between components

## API Integration

The application uses [JSONPlaceholder](https://jsonplaceholder.typicode.com) as a mock API:
- Endpoint: `/posts`
- Tenant Header: `X-Tenant-ID`
- Response Format: JSON

## Error Handling

The application handles various error scenarios:
- Invalid tenant IDs
- Network connectivity issues
- API response errors
- Data deserialization problems

## Future Enhancements

Potential improvements that could be made:
- Add unit tests
- Implement caching
- Add configuration file support
- Enhance error handling
- Add more data visualization options
- Implement real API integration

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## Acknowledgments

- JSONPlaceholder for providing the mock API
- .NET community for tools and support 
