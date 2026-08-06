using MvcMovie.Models;

namespace MvcMovie.Data;

public static class SeedData
{
    public static void Initialize(MvcMovieContext context)
    {
        if (context.Movie.Any())
        {
            return;
        }

        context.Movie.AddRange(
            new Movie
            {
                Title = "Spider-Man: Brand New Day",
                ReleaseDate = new DateTime(2026, 7, 31),
                Genre = "Science Fiction",
                Price = 320,
                PosterUrl = "/images/spiderman.png"
            },
            new Movie
            {
                Title = "Train to Busan",
                ReleaseDate = new DateTime(2016, 7, 20),
                Genre = "Horror",
                Price = 120,
                PosterUrl = "/images/train_to_busan.jpg"
            },
            new Movie
            {
                Title = "Black Widow",
                ReleaseDate = new DateTime(2021, 7, 9),
                Genre = "Action",
                Price = 400,
                PosterUrl = "/images/blackwidow.png"
            },
            new Movie
            {
                Title = "Avengers: Endgame",
                ReleaseDate = new DateTime(2019, 4, 26),
                Genre = "Action",
                Price = 550,
                PosterUrl = "/images/endgame_poster.jpg"
            },
            new Movie
            {
                Title = "Obsession",
                ReleaseDate = new DateTime(2015, 5, 15),
                Genre = "Horror",
                Price = 235,
                PosterUrl = "/images/obsession.png"
            },
            new Movie
            {
                Title = "Demon Slayer",
                ReleaseDate = new DateTime(2020, 10, 16),
                Genre = "Anime",
                Price = 300,
                PosterUrl = "/images/demon slayer.jpg"
            },
            new Movie
            {
                Title = "Midnight",
                ReleaseDate = new DateTime(2021, 6, 30),
                Genre = "Thriller",
                Price = 280,
                PosterUrl = "/images/mid_night.png"
            },
            new Movie
            {
                Title = "Moana",
                ReleaseDate = new DateTime(2016, 11, 23),
                Genre = "Animation",
                Price = 220,
                PosterUrl = "/images/moana.png"
            },
            new Movie
            {
                Title = "Mulan",
                ReleaseDate = new DateTime(2020, 9, 4),
                Genre = "Adventure",
                Price = 250,
                PosterUrl = "/images/mulan.png"
            },
            new Movie
            {
                Title = "Ready or Not",
                ReleaseDate = new DateTime(2019, 8, 21),
                Genre = "Horror",
                Price = 400,
                PosterUrl = "/images/ready-or-not.png"
            },
            new Movie
            {
                Title = "Talk to Me",
                ReleaseDate = new DateTime(2022, 7, 28),
                Genre = "Horror",
                Price = 350,
                PosterUrl = "/images/talk_to_me.jpg"
            },
            new Movie
            {
                Title = "The Odyssey",
                ReleaseDate = new DateTime(2026, 7, 17),
                Genre = "Adventure",
                Price = 450,
                PosterUrl = "/images/the odyssey.png"
            }
        );

        context.SaveChanges();
    }
}