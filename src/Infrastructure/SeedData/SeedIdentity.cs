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
        storeOwner201.SecurityStamp = Guid.NewGuid().ToString("D");

        // StoreOwner with Id 201
        var storeOwner202 = new User();
        storeOwner202.UserName = "storeowner202@gmail.com";
        storeOwner202.NormalizedUserName = "storeowner202@gmail.com".ToUpper();
        storeOwner202.Address = "Le Duan, Da Nang";
        storeOwner202.Email = "storeowner202@gmail.com";
        storeOwner202.NormalizedUserName = "storeowner202@gmail.com".ToUpper();
        storeOwner202.Id = 202;
        storeOwner202.PasswordHash = hasher.HashPassword(null, "Default@123");
        storeOwner202.SecurityStamp = Guid.NewGuid().ToString("D");

        // Admin 
        var admin = new User();
        admin.UserName = "admin@gmail.com";
        admin.NormalizedUserName = "admin@gmail.com".ToUpper();
        admin.Address = "Le Duan, Da Nang";
        admin.Email = "admin@gmail.com";
        admin.NormalizedUserName = "admin@gmail.com".ToUpper();
        admin.Id = 999;
        admin.PasswordHash = hasher.HashPassword(null, "Default@123");
        admin.SecurityStamp = Guid.NewGuid().ToString("D");

        // Customer
        var customer100 = new User();
        customer100.UserName = "customer100@gmail.com";
        customer100.NormalizedUserName = "customer100@gmail.com".ToUpper();
        customer100.Address = "Le Duan, Da Nang";
        customer100.Email = "customer100@gmail.com";
        customer100.NormalizedUserName = "customer100@gmail.com".ToUpper();
        customer100.Id = 100;
        customer100.PasswordHash = hasher.HashPassword(null, "Default@123");
        customer100.SecurityStamp = Guid.NewGuid().ToString("D");
        
        
        var customer101 = new User();
        customer101.UserName = "customer101@gmail.com";
        customer101.NormalizedUserName = "customer101@gmail.com".ToUpper();
        customer101.Address = "Le Duan, Da Nang";
        customer101.Email = "customer101@gmail.com";
        customer101.NormalizedUserName = "customer101@gmail.com".ToUpper();
        customer101.Id = 101;
        customer101.PasswordHash = hasher.HashPassword(null, "Default@123");
        customer101.SecurityStamp = Guid.NewGuid().ToString("D");

        var customer102 = new User();
        customer102.UserName = "customer102@gmail.com";
        customer102.NormalizedUserName = "customer102@gmail.com".ToUpper();
        customer102.Address = "Le Duan, Da Nang";
        customer102.Email = "customer102@gmail.com";
        customer102.NormalizedUserName = "customer102@gmail.com".ToUpper();
        customer102.Id = 102;
        customer102.PasswordHash = hasher.HashPassword(null, "Default@123");
        customer102.SecurityStamp = Guid.NewGuid().ToString("D");

        
        var customer103 = new User();
        customer103.UserName = "customer103@gmail.com";
        customer103.NormalizedUserName = "customer103@gmail.com".ToUpper();
        customer103.Address = "Le Duan, Da Nang";
        customer103.Email = "customer103@gmail.com";
        customer103.NormalizedUserName = "customer103@gmail.com".ToUpper();
        customer103.Id = 103;
        customer103.PasswordHash = hasher.HashPassword(null, "Default@123");
        customer103.SecurityStamp = Guid.NewGuid().ToString("D");

        
        builder.Entity<User>().HasData(
            admin,
            storeOwner201,
            storeOwner202,
            customer103,
            customer101,
            customer102,
            customer100
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
                // Customer 100
                RoleId = 102,
                UserId = 100,
            },
        new IdentityUserRole<int>
            {
                // Customer 101
                RoleId = 102,
                UserId = 101,
            },
        new IdentityUserRole<int>
            {
                // Customer 102
                RoleId = 102,
                UserId = 102,
            },
        new IdentityUserRole<int>
            {
                // Customer 103
                RoleId = 102,
                UserId = 103,
            }
            
            
        );
    }

}