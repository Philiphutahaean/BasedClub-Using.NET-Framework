using BasedClub.Models;
using Microsoft.EntityFrameworkCore;
namespace BasedClub.Data;
public static class ModelBuilderExtensions
{
    public static ModelBuilder Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
         new Product
         {
             Id = 1,
             Name = "Based Club in Just 1 Night",
             Description = "Kaos murah dengan design elegan",
             Price = 150000,
             ImageName = "based-club-injut1night.jpg"
         },

    new Product
    {

        Id = 2,
        Name = "Based Club Kitten",
        Description = "Kaos murah dengan design kekinian",
        Price = 140000,
        ImageName = "Based-Club-Kitten.jpg"
    },
    new Product
    {

        Id = 3,
        Name = "Based Club Retro",
        Description = "Kaos murah dengan design yang wow",
        Price = 140000,
        ImageName = "Based-Club-Retro.jpg"
    },
    new Product
    {
        Id = 4,
        Name = "Based Club Star",
        Description = "Kaos murah dengan design yang mencengangkan",
        Price = 170000,
        ImageName = "Based-Club-Bintang.jpg"
    },
    new Product
    {
        Id = 5,
        Name = "Based Club Girl",
        Description = "Kaos murah dengan design yang out of the box",
        Price = 190000,
        ImageName = "Based-Club-Girl.jpg"
    },
    new Product
    {
        Id = 6,
        Name = "Based Club Ear",
        Description = "Kaos murah dengan design yang diluar nalar",
        Price = 200000,
        ImageName = "Based-Club-Sexy.jpg"

    }

    );
        return modelBuilder;
    }
}