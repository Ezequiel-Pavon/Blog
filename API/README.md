# Blog.API README.md

# Blog Social API

This project is a Web API built with ASP.NET Core that implements a "Blog Social" model. It provides CRUD operations for users, posts, comments, likes, and friend requests, utilizing SQLite as the database through Entity Framework Core.

## Project Structure

- **Controllers/**: Contains the API controllers for handling requests related to Users, Posts, Comments, Likes, and Friend Requests.
- **Data/**: Contains the `BlogContext` class for database interactions and configurations for each entity.
- **Models/**: Contains the entity classes representing the data structure of the application, including navigation properties.
- **Models/Enums/**: Contains the enumeration for friend request statuses.
- **appsettings.json**: Configuration file for application settings, including the SQLite connection string.
- **Program.cs**: The entry point of the application, configuring services and middleware.

## Getting Started

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd Blog.API
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

## API Endpoints

- **Users**: `/api/users`
- **Posts**: `/api/posts`
- **Comments**: `/api/comments`
- **Likes**: `/api/likes`
- **Friend Requests**: `/api/friendrequests`

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- SQLite

## License

This project is licensed under the MIT License. See the LICENSE file for details.