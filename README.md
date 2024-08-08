# Tunify-Platform

## Brief Description
The Tunify Platform is a comprehensive music streaming application designed to provide users with an immersive and seamless experience. It allows users to explore a vast library of songs, albums, and playlists curated by various artists. Users can create and manage their own playlists and subscribe to the platform for additional features and content. The platform's robust architecture ensures efficient data management and retrieval, leveraging the power of Entity Framework Core and SQL Server.

### Relationship Overview

- **One-to-Many**:
  - `User` to `Subscription`: A `Subscription` can have many `Users`, but each `User` has one `Subscription`.
  - `Album` to `Artist`: An `Artist` can have many `Albums`, but each `Album` is created by one `Artist`.
  - `Song` to `Album`: An `Album` can have many `Songs`, but each `Song` belongs to one `Album`.
  - `Song` to `Artist`: An `Artist` can perform many `Songs`, but each `Song` is performed by one `Artist`.
  - `Playlist` to `User`: A `User` can create many `Playlists`, but each `Playlist` is created by one `User`.

- **Many-to-Many**:
  - `Playlist` to `Song`: A `Playlist` can contain many `Songs`, and a `Song` can be part of many `Playlists`. This relationship is represented by the `PlaylistSongs` entity.

## Repository Design Pattern

### What is the Repository Pattern?

The Repository Design Pattern is a well-established software design pattern used to abstract data access logic and separate it from the business logic of an application. This pattern creates a bridge between the data source (e.g., databases) and the application, providing a clean and consistent way to access and manipulate data.

### Benefits of the Repository Pattern

- **Separation of Concerns**: The Repository Pattern promotes a clear separation between the data access logic and the business logic, making the codebase more maintainable and easier to understand.

- **Testability**: By abstracting the data access layer, repositories allow for easier unit testing. Mocks or stubs can be created for the repository interfaces, enabling the testing of business logic without requiring a database connection.

- **Modularity**: Repositories encapsulate data access logic, making it easier to manage and modify. If the underlying data source changes (e.g., switching from SQL Server to another database), only the repository implementation needs to be updated, without affecting the rest of the application.

- **Reusability**: Repositories can be reused across different parts of the application, reducing code duplication and promoting DRY (Don't Repeat Yourself) principles.

- ## Tunify ERD Diagram
![Tunify ERD Diagram](Tunify-Platform/Assets/Tunify.png)

