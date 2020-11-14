using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Legend of Johnny Lingo",
                        ReleaseDate = DateTime.Parse("2004-5-11"),
                        Genre = "Family",
                        Rating = "G",
                        Price = 7.99M,
                        ImagePath = "JohnnyLingo"
                    },

                    new Movie
                    {
                        Title = "Meet The Mormons",
                        ReleaseDate = DateTime.Parse("2014-8-10"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 8.99M,
                        ImagePath = "MeetTheMormons"
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers",
                        ReleaseDate = DateTime.Parse("2003-9-11"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 9.99M,
                        ImagePath = "SaintsAndSoldiers"
                    }

                ); 
                context.SaveChanges();
            }
        }
    }
}