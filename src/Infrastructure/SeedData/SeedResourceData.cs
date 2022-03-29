using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.SeedData;

  public static class SeedResourceData
    {
        public static void SeedCategories(ModelBuilder builder)
        {
            builder.Entity<Category>()
                .HasData(
                    new Category()
                    {
                        Id = 1,
                        Name = "Calligraphy",
                        Description =
                            "Large collection of new and used Calligraphy Books. Obtain your favorite Calligraphy Books at much lower prices than other booksellers."
                    },
                    new Category()
                    {
                        Id = 2,
                        Name = "History",
                        Description = "Shop our collection of new & used history books from local history, to world history, ancient history books, & more! Read more & spend less on ThriftBooks."
                    });
        }

        public static void SeedBooks(ModelBuilder builder)
        {
            builder.Entity<Book>()
                .HasData(
                    new Book()
                    {
                        Id = 1,
                        Name = "Learn Calligraphy: The Complete Book of Lettering and Design",
                        Description =
                            "In an age of myriad computer fonts and instant communication, your handwriting style is increasingly a very personal creation. In this book, Margaret Shepherd, America's premier calligrapher, shows you that calligraphy is not simply a craft you can learn, but an elegant art form that you can make your own. Calligraphy remains perennially popular, often adorning wedding invitations, diplomas, and commercial signs. Whether it is Roman, Gothic, Celtic,..."
                        ,
                        Price = 50000,
                        Quantity = 100,
                        CategoryId = 1,
                        CreatedOn = DateTime.Now,
                        CreatedBy = 999,
                        
                    },
                    new Book()
                    {
                        Id = 2,
                        Name = "Cook, Eat, Cha Cha Cha: Festive New World Recipes",
                        Description = "New World cooking is hot, hot, hot -- and very cool. At San Francisco's famous Cha Cha Cha restaurant, located in the heart of Haight-Ashbury, the big flavors of Cuba and Puerto Rico come together and dance in vibrant dishes served against a backdrop of laughter, a loud Latin beat, and fabulous altars to the voodoo saint-gods of Santeria. As colorful as the restaurant itself, this unique, festive cookbook offers sixty terrific recipes for Cha Cha...",
                        Price = 100000,
                        Quantity = 50,
                        CategoryId = 2,
                        CreatedOn = DateTime.Now,
                        CreatedBy = 999,
                    });
        }
    }