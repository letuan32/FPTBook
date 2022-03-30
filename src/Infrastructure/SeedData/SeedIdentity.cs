using System.Runtime.CompilerServices;
using Domain.Entities;
using Infrastructure.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Infrastructure.SeedData;

public static  class SeedIdentity
{
    public static void Seeds(ModelBuilder builder)
    {
        SeedRoles(builder);
        SeedUsers(builder);
        SeedUserRoles(builder);
    }
    private static void SeedRoles(ModelBuilder builder)
    {
        builder.Entity<Role>()
            .HasData(
                new Role()
                {
                    Id= 100,
                    Name = RoleConstant.Admin,
                    NormalizedName = RoleConstant.Admin.ToUpper()
                },
                new Role()
                {
                    Id = 101,
                    Name = RoleConstant.StoreOwner,
                    NormalizedName = RoleConstant.StoreOwner.ToUpper()
                },
                new Role()
                {
                    Id = 102,
                    Name = RoleConstant.Customer,
                    NormalizedName = RoleConstant.Customer.ToUpper()
                });
    }
    private static void SeedUsers(ModelBuilder builder)
    { 
        var hasher = new PasswordHasher<User>();
        // StoreOwner with Id 201
        var storeOwner201 = new User();
        storeOwner201.UserName = "storeowner201@gmail.com";
        storeOwner201.NormalizedUserName = "storeowner201@gmail.com".ToUpper();
        storeOwner201.Address = "Le Duan, Da Nang";
        storeOwner201.Email = "storeowner201@gmail.com";
        storeOwner201.NormalizedUserName = "storeowner201@gmail.com".ToUpper();
        storeOwner201.Id = 201;
        storeOwner201.PasswordHash = hasher.HashPassword(null, "Default@123");
        
        // StoreOwner with Id 201
        var storeOwner202 = new User();
        storeOwner202.UserName = "storeowner202@gmail.com";
        storeOwner202.NormalizedUserName = "storeowner202@gmail.com".ToUpper();
        storeOwner202.Address = "Le Duan, Da Nang";
        storeOwner202.Email = "storeowner202@gmail.com";
        storeOwner202.NormalizedUserName = "storeowner202@gmail.com".ToUpper();
        storeOwner202.Id = 202;
        storeOwner202.PasswordHash = hasher.HashPassword(null, "Default@123");

        // Admin 
        var admin = new User();
        admin.UserName = "admin@gmail.com";
        admin.NormalizedUserName = "admin@gmail.com".ToUpper();
        admin.Address = "Le Duan, Da Nang";
        admin.Email = "admin@gmail.com";
        admin.NormalizedUserName = "admin@gmail.com".ToUpper();
        admin.Id = 999;
        admin.PasswordHash = hasher.HashPassword(null, "Default@123");
        
        // Customer
        var customer = new User();
        customer.UserName = "customer@gmail.com";
        customer.NormalizedUserName = "customer@gmail.com".ToUpper();
        customer.Address = "Le Duan, Da Nang";
        customer.Email = "customer@gmail.com";
        customer.NormalizedUserName = "customer@gmail.com".ToUpper();
        customer.Id = 100;
        customer.PasswordHash = hasher.HashPassword(null, "Default@123");
        
        
        builder.Entity<User>().HasData(
            admin,
            storeOwner201,
            storeOwner202,
            customer
        );
    }

    private static void SeedUserRoles(ModelBuilder builder)
    {
        builder.Entity<IdentityUserRole<int>>().HasData(
            new IdentityUserRole<int>
            {
                // Admin
                RoleId = 100,
                UserId = 999
            },
            new IdentityUserRole<int>
            {
                // Store Owner 201
                RoleId = 101,
                UserId = 201,
            },
            new IdentityUserRole<int>
            {
                // Store Owner 202
                RoleId = 101,
                UserId = 202,
            },
            new IdentityUserRole<int>
            {
                // Store Owner 202
                RoleId = 102,
                UserId = 100,
            }
            
            
        );
    }

}