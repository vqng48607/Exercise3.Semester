using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Data
{

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MusicStoreContext(
                serviceProvider.GetRequiredService<DbContextOptions<MusicStoreContext>>()))
            {
                if(!context.Artist.Any())
                {
                    context.Artist.AddRange(
                        new Artist { Name = "Test Artist 1"},
                        new Artist { Name = "Test Artist 2"}
                        );
                    context.SaveChanges();
                }
                if(!context.Genre.Any())
                {
                    context.Genre.AddRange(
                        new Genre { Name = "Pop", Description = "Pop1" },
                        new Genre { Name = "Hiphop", Description = "Hiphop1" }
                        );
                    context.SaveChanges();
                }
                if (!context.Album.Any())
                {
                    
                    context.Album.AddRange(
                        new Album { Title = "Title1", Price = 1.1m, AlbumArtUrl = "Test 1", ArtistId = 1, GenreId = 1},

                        new Album { Title = "Title2", Price = 2.2m, AlbumArtUrl = "Test 2", ArtistId = 2, GenreId = 2}
                    );
                    
                    context.SaveChanges();
                }
            }
        }
    }


}
