# ChallengeAppAPI

ChallengeAppAPI is a RESTful API built using C# ASP.NET Core that serves as the backend for the ChallengeApp mobile application. It provides endpoints for managing users, posts, comments, and more, facilitating the social experience of the ChallengeApp platform.

## Technologies Used

- C# ASP.NET Core
- Entity Framework Core for SQL database interaction
- SQL Server for data storage
- Azure Blob Storage for storing images and videos
- JSON Web Tokens (JWT) for authorization
- Swagger for API documentation

## Features

- **User Management**: Endpoints for user registration, login, and profile management.
- **Post Management**: CRUD operations for creating, reading, updating, and deleting posts.
- **Comment Management**: Ability to add comments to posts and retrieve comments for a specific post.
- **Authorization**: JWT-based authentication to secure API endpoints.
- **Azure Integration**: Storage of images and videos on Azure Blob Storage.

## Getting Started

To get started with ChallengeAppAPI, follow these steps:

1. Clone this repository to your local machine.
2. Configure your Azure Blob Storage connection settings in `appsettings.json`.
3. Ensure you have SQL Server installed and running, and update the connection string in `appsettings.json` accordingly.
4. Build and run the API project.
5. Use Swagger documentation to explore and test API endpoints.

