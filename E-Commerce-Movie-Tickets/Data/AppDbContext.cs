using E_Commerce_Movie_Tickets.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Movie_Tickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.MovieId,
                am.ActorId

            });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id=1, FullName = "Liam Hemsworth", Bio = "Bio 1", profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/a1.jpg" },
                new Actor { Id = 2, FullName = "Tom Cruise", Bio = "Bio 2", profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/a2.jpg" },
                new Actor { Id = 3, FullName = "Brad Pitt", Bio = "Bio 3", profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/a3.jpg" }
                );
            modelBuilder.Entity<Cinema>().HasData(
                new Cinema { Id = 1, Name = "Cinema 1", Logo = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/1.jpg", Description = "Description 1" },
                new Cinema { Id = 2, Name = "Cinema 2", Logo = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/2.jpg", Description = "Description 2" },
                new Cinema { Id = 3, Name = "Cinema 3", Logo = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/3.jpg", Description = "Description 3" }

                );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "Movie 1", Description = "Description 1", Price = 20.5, ImageURL = "", StartDate = System.DateTime.Now.AddDays(-10), EndDate = System.DateTime.Now.AddDays(-5), CinemaId = 1, ProducerId = 2, MovieCategory = MovieCategory.Comedy },
                new Movie { Id = 2, Name = "Movie 2", Description = "Description 2", Price = 30.00, ImageURL = "", StartDate = System.DateTime.Now, EndDate = System.DateTime.Now.AddDays(7), CinemaId = 2, ProducerId = 1, MovieCategory = MovieCategory.Drama },
                new Movie { Id = 3, Name = "Movie 3", Description = "Description 3", Price = 15.00, ImageURL = "", StartDate = System.DateTime.Now.AddDays(3), EndDate = System.DateTime.Now.AddDays(20), CinemaId = 3, ProducerId = 3, MovieCategory = MovieCategory.Action }
                );
            modelBuilder.Entity<Producer>().HasData(
                new Producer { Id = 1, FullName = "Producer 1", Bio = "producer 1", profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/p1.jpg" },
                new Producer { Id = 2, FullName = "Producer 2", Bio = "producer 2", profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/p1.jpg" },
                new Producer { Id = 3, FullName = "Producer 3", Bio = "producer 3", profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/p1.jpg" }
                      );
            modelBuilder.Entity<Actor_Movie>().HasData(
             new Actor_Movie {ActorId=2,MovieId=1 },
             new Actor_Movie {ActorId=3,MovieId=1 },
             new Actor_Movie {ActorId=1,MovieId=2 },
             new Actor_Movie {ActorId=2,MovieId=2 },
             new Actor_Movie {ActorId=2,MovieId=3 },
             new Actor_Movie {ActorId=1,MovieId=3 },
             new Actor_Movie {ActorId=3,MovieId=3 }
                    );
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<Producer> Producers { get; set; }

    }
}
