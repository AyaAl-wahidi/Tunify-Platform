# Tunify-Platform

## Brief Description
The Tunify Platform is a comprehensive music streaming application designed to provide users with an immersive and seamless experience. It allows users to explore a vast library of songs, albums, and playlists curated by various artists. Users can create and manage their own playlists and subscribe to the platform for additional features and content. The platform's robust architecture ensures efficient data management and retrieval, leveraging the power of Entity Framework Core and SQL Server.

## Tunify ERD Diagram
![Tunify ERD Diagram](Tunify-Platform/Assets/Tunify.png)

### Relationship Overview

- **One-to-Many**:
  - `User` to `Subscription`: A `Subscription` can have many `Users`, but each `User` has one `Subscription`.
  - `Album` to `Artist`: An `Artist` can have many `Albums`, but each `Album` is created by one `Artist`.
  - `Song` to `Album`: An `Album` can have many `Songs`, but each `Song` belongs to one `Album`.
  - `Song` to `Artist`: An `Artist` can perform many `Songs`, but each `Song` is performed by one `Artist`.
  - `Playlist` to `User`: A `User` can create many `Playlists`, but each `Playlist` is created by one `User`.

- **Many-to-Many**:
  - `Playlist` to `Song`: A `Playlist` can contain many `Songs`, and a `Song` can be part of many `Playlists`. This relationship is represented by the `PlaylistSongs` entity.
