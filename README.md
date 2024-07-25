# Project Title: CleanArchitectureEasySample
# Editor: Amal Balouchi

## Introduction
This project is a .NET application demonstrating the Clean Architecture design pattern. 
Clean Architecture ensures that the business logic and application logic are separated from the infrastructure and frameworks, 
making the codebase more maintainable, testable, and scalable.

## Architecture Overview
The Clean Architecture design pattern is implemented in this project with the following key components:
- **Domain Layer**: Contains the business logic and entities.
- **Application Layer**: Contains use cases, services, and interfaces.
- **Infrastructure Layer**: Contains external dependencies like database access, third-party services, and file system interactions.
- **Presentation Layer**: Contains the user interface, which is the console application in our case.

## Technologies Used
- **.NET 7**: For building the application.
- **Entity Framework Core**: For data access.
- **GIT**: For version control.


## Setup and Installation
1. **Clone the repository**:
    ```sh
    git clone [copy-the-link]
    cd your-repo-name
    ```

2. **Build the solution**:
    ```sh
    dotnet build
    ```

3. **Update the database** (if using Entity Framework Core):
    ```sh
    dotnet ef database update
    ```

4. **Run the application**:
    - Set the startup project to the executable project (ConsoleApp named MainApp).
    - Run the project using Visual Studio or the .NET CLI:
    ```sh
    dotnet run --project [path-to-the-startup-project]
    ```

## Usage
- **Debugging**: To debug the project, set the startup project to the executable project and run it in debug mode. You can set breakpoints in the class library and step through the code.
