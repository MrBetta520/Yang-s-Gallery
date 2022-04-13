using Microsoft.EntityFrameworkCore;

namespace Assignment12._2._2.Models
{
    public class DrawContext : DbContext
    {
        public DrawContext(DbContextOptions<DrawContext> options) : base(options)
        {

        }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<Draw> Draws { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, CountryName = "Italy" },
                new Country { CountryId = 2, CountryName = "Holland" },
                new Country { CountryId = 3, CountryName = "French" });

            modelBuilder.Entity<Draw>().HasData(
                new Draw()
                {
                    Id = 101,
                    Author = "Leonardo Da Vinci",
                    Name = "Mona Lisa",
                    Description = "The Mona Lisa is an oil painting by Italian artist, inventor, and " +
                                  "writer Leonardo da Vinci. Likely completed in 1506, the piece features a " +
                                  "portrait of a seated woman set against an imaginary landscape. In addition " +
                                  "to being one of the most famous paintings, it is also the most valuable.",
                    Price = 561.30,
                    ImageUrl = "monalisa.jpg",
                    CountryId = 1,
                    Country=CountryName.Italy
                },
                new Draw()
                {
                    Id = 102,
                    Author = "Van Gogh",
                    Name = "Sunflower",
                    Description = "Vincent painted a total of five large canvases with sunflowers in a vase, with " +
                                  "three shades of yellow 'and nothing else'. In this way, he demonstrated that it was " +
                                  "possible to create an image with numerous variations of a single colour, without any " +
                                  "loss of eloquence.",
                    Price = 191.40,
                    ImageUrl = "sunflower.jpg",
                    CountryId = 2,
                    Country = CountryName.Holland
                },
                new Draw()
                {
                    Id = 103,
                    Author = "Jan Van Eyck",
                    Name = "Arnolfini Portrait",
                    Description = "The Arnolfini Portrait provides a clear pictorial record of the rank and social status" +
                                  " of the subjects. The woman's robe is trimmed with ermine fur and consists of an " +
                                  "inordinate amount of fabric. A personal maid would have been needed to accompany the " +
                                  "woman, to hold the garment off the ground.",
                    Price = 211.40,
                    ImageUrl = "arnolfiniPortrait.jpg",
                    CountryId = 1,
                    Country = CountryName.Italy
                });
        }

    }
}
