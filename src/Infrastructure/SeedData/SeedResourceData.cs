using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Infrastructure.SeedData;

  public static class SeedResourceData
    {
        public static void SeedCategories(ModelBuilder builder)
        { 
            var categories = new List<Category>();
          using (StreamReader r = new StreamReader("./wwwroot/jsonData/categories.json"))
          {
              string json = r.ReadToEnd();
              categories = JsonConvert.DeserializeObject<List<Category>>(json);
          }
          builder.Entity<Category>()
              .HasData(categories);
        }

        public static void SeedBooks(ModelBuilder builder)
        {
            var books = new List<Book>();
            using (StreamReader r = new StreamReader("./wwwroot/jsonData/books.json"))
            {
                string json = r.ReadToEnd();
             
                books = JsonConvert.DeserializeObject<List<Book>>(json);
            }
            builder.Entity<Book>()
                .HasData(books);
           
        }
    }