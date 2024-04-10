using Microsoft.EntityFrameworkCore;
using MvcICT.Data;

namespace MvcICT.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcICTContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcICTContext>>())) 
            {
                if(context.Video.Any())
                {
                    return;
                }

                context.Video.AddRange(
                    new Video
                    {
                        Title = "Ends Vol. 1",
                        ReleaseDate = DateTime.Parse("2022-06-20"),
                        Genre = "Navigation",
                        Rating = "OK"
                    },
                    new Video
                    {
                        Title = "Ends Vol. 2",
                        ReleaseDate = DateTime.Parse("2022-08-06"),
                        Genre = "Navigation",
                        Rating = "Bad"
                    },
                    new Video
                    {
                        Title = "Ends Vol. 3",
                        ReleaseDate = DateTime.Parse("2022-08-27"),
                        Genre = "Navigation",
                        Rating = "Amazing"
                    },
                    new Video
                    {
                        Title = "Ends Vol. 4",
                        ReleaseDate = DateTime.Parse("2022-09-07"),
                        Genre = "Navigation",
                        Rating = "Informative"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
