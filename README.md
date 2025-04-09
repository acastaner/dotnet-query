# MyDotNetCoreWebApp

This is a simple .NET Core web application that demonstrates how to retrieve and display a query parameter from the URL.

## Project Structure

- **Controllers**: Contains the controllers for handling requests.
  - `HomeController.cs`: Manages the home page and retrieves the query parameter.
  
- **Models**: Contains the data models used in the application.
  - `QueryParameterModel.cs`: Defines the model for holding the query parameter value.
  
- **Views**: Contains the Razor views for rendering HTML.
  - **Home**: Contains views related to the home page.
    - `Index.cshtml`: Displays the value of the query parameter.
  - **Shared**: Contains shared views and layout.
    - `_Layout.cshtml`: Provides a common layout for the views.
  
- **wwwroot**: Contains static files such as CSS.
  - **css**: Contains CSS files for styling.
    - `site.css`: Minimal CSS styles for the application.
  
- **Configuration Files**:
  - `appsettings.json`: Configuration settings for the application.
  - `Program.cs`: Entry point of the application.
  - `Startup.cs`: Configures services and the request pipeline.

## How to Run

1. Ensure you have the .NET Core SDK installed.
2. Open a terminal and navigate to the project directory.
3. Run the application using the command:
   ```
   dotnet run
   ```
4. Open a web browser and navigate to `http://localhost:5000/?param=value` to see the query parameter displayed on the home page.

## Features

- Retrieves a query parameter from the URL.
- Displays the value on the home page.
- Minimal CSS for basic styling.