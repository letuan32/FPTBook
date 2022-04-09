using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Infrastructure.SeedData;

  public static class SeedResourceData
    {
        public static void Seeds(ModelBuilder builder)
        {
            SeedCategories(builder);
            SeedBooks(builder);
            SeedOrder(builder);
            SeedOrderItems(builder);
        }
        private static void SeedCategories(ModelBuilder builder)
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

        private static void SeedBooks(ModelBuilder builder)
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
        
        private static void SeedOrder(ModelBuilder builder)
        {
            var orders = new List<Order>();
            using (StreamReader r = new StreamReader("./wwwroot/jsonData/orders.json"))
            {
                string json = r.ReadToEnd();
             
                orders = JsonConvert.DeserializeObject<List<Order>>(json);
            }
            builder.Entity<Order>()
                .HasData(orders);
        }

        private static void SeedOrderItems(ModelBuilder builder)
        {
            var orderItems = new List<OrderItem>();
            using (StreamReader r = new StreamReader("./wwwroot/jsonData/orderitems.json"))
            {
                string json = r.ReadToEnd();
             
                orderItems = JsonConvert.DeserializeObject<List<OrderItem>>(json);
            }
            builder.Entity<OrderItem>()
                .HasData(orderItems);
        }
    }