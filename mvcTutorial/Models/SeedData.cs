using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace mvcTutorial.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new mvcTutorialContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<mvcTutorialContext>>()))
            {
                    //look for any movies
                if (context.Movie.Any())
                {
                    return; //DB has been seeded already
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Star Wars: A New Hope",
                        ReleaseDate = DateTime.Parse("1977 - 5 - 25"),
                        Genre = "Science Fiction",
                        Price = 15.99M
                    },

                    new Movie
                    {
                        Title = "Star Wars: The Empire Strikes Back",
                        ReleaseDate = DateTime.Parse("1980 - 5 - 27"),
                        Genre = "Science Fiction",
                        Price = 19.99M
                    },

                    new Movie
                    {
                        Title = "Star Wars: Return of the Jedi",
                        ReleaseDate = DateTime.Parse("1983 - 5 - 25"),
                        Genre = "Science Fiction",
                        Price = 15.99M
                    }
                );
            }
        }
    }
}
