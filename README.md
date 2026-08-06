# 🎬 MvcMovie

A responsive movie collection management web application built with ASP.NET Core MVC.

🔗 **Live Demo:** https://mvcmovie-production.up.railway.app

## Overview

MvcMovie allows users to manage a personal movie collection through a clean, responsive interface. Users can browse movie cards, search by title, view movie details, add new movies, edit existing movies, and delete movies safely.

## Features

- Create, read, update, and delete movies (CRUD)
- Search movies by title
- Case-insensitive search
- Form validation for adding and editing movies
- Movie poster support using local image paths
- Responsive design for desktop and mobile
- Seed data to display initial movies automatically
- Confirmation page before deleting a movie

## Technologies Used

- ASP.NET Core MVC
- C#
- Entity Framework Core
- SQLite
- Razor Views
- Bootstrap
- HTML and CSS
- Docker
- Railway for deployment

## Project Structure

```text
Controllers/        Handles application requests and CRUD actions
Models/             Defines the Movie model and validation rules
Models/Data/        Contains DbContext and seed data
Views/              Razor pages for Home and Movies
Migrations/         Entity Framework Core database migrations
wwwroot/images/     Movie poster images
Program.cs          Configures services, routing, database, and migrations
Dockerfile          Deployment configuration for Railway
```

## Main Functionality

| Feature | Description |
|---|---|
| Browse Movies | Displays movies as responsive poster cards |
| Search | Finds movies by title without case sensitivity |
| Add Movie | Saves a new movie with title, date, genre, price, and poster |
| Details | Displays information for one selected movie |
| Edit Movie | Updates existing movie information |
| Delete Movie | Shows a confirmation page before removing a movie |

## Run Locally

1. Clone the repository:

```bash
git clone https://github.com/YOUR-USERNAME/MvcMovie.git
```

2. Open the project folder:

```bash
cd MvcMovie
```

3. Run the application:

```bash
dotnet run
```

4. Open the local URL displayed in the terminal, usually:

```text
http://localhost:5025
```

## Database

The application uses SQLite with Entity Framework Core.

- `MvcMovieContext` connects the application to the database.
- Migrations create and update the database structure.
- `SeedData` adds initial movies when the database is empty.
- Migrations are applied automatically when the application starts.

## Author

Haneen Abdelmeeged
