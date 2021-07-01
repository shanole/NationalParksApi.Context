using Microsoft.EntityFrameworkCore;
using System;

namespace NationalParksApi.Models
{
    public class NationalParksApiContext : DbContext
    {
        public NationalParksApiContext(DbContextOptions<NationalParksApiContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
            .HasData(new Park { ParkId = 1, Name = "Mount Rainieir", Location = "Washington", AreaKmSquared = 956.6f, Description = "Mount Rainier, an active stratovolcano, is the most prominent peak in the Cascades and is covered by 26 named glaciers including Carbon Glacier and Emmons Glacier, the longest and largest in the contiguous United States respectively. The mountain is popular for climbing, and more than half of the park is covered by subalpine and alpine forests and meadows seasonally in bloom with wildflowers. Paradise on the south slope is among the snowiest places on Earth. The Longmire visitor center is the start of the Wonderland Trail, which encircles the mountain."},
            new Park{ ParkId = 2, Name = "Zion", Location = "Utah", AreaKmSquared = 595.9f, Description = "4,488,268	Located at the junction of the Colorado Plateau, Great Basin, and Mojave Desert, this park contains sandstone features such as mesas, rock towers, and canyons, including the Virgin River Narrows. The various sandstone formations and the forks of the Virgin River create a wilderness divided into four ecosystems: desert, riparian, woodland, and coniferous forest." });
        }
    }
}