using System;
using System.Collections.Generic;
using System.Text;
using Bangazon.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.Data {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            base.OnModelCreating (modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            modelBuilder.Entity<Order> ()
                .Property (b => b.DateCreated)
                .HasDefaultValueSql ("GETDATE()");

            // Restrict deletion of related order when OrderProducts entry is removed
            modelBuilder.Entity<Order> ()
                .HasMany (o => o.OrderProducts)
                .WithOne (l => l.Order)
                .OnDelete (DeleteBehavior.Restrict);

            modelBuilder.Entity<Product> ()
                .Property (b => b.DateCreated)
                .HasDefaultValueSql ("GETDATE()");

            // Restrict deletion of related product when OrderProducts entry is removed
            modelBuilder.Entity<Product> ()
                .HasMany (o => o.OrderProducts)
                .WithOne (l => l.Product)
                .OnDelete (DeleteBehavior.Restrict);

            modelBuilder.Entity<PaymentType> ()
                .Property (b => b.DateCreated)
                .HasDefaultValueSql ("GETDATE()");


            ApplicationUser user = new ApplicationUser {
                FirstName = "admin",
                LastName = "admin",
                StreetAddress = "123 Infinity Way",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid ().ToString ("D")
            };
            var passwordHash = new PasswordHasher<ApplicationUser> ();
            user.PasswordHash = passwordHash.HashPassword (user, "Admin8*");
            modelBuilder.Entity<ApplicationUser> ().HasData (user);

            ApplicationUser user1 = new ApplicationUser
            {
                FirstName = "Test",
                LastName = "Smith",
                StreetAddress = "123 Main Way",
                UserName = "test@test.com",
                NormalizedUserName = "TEST@TEST.COM",
                Email = "test@test.com",
                NormalizedEmail = "TEST@TEST.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash1 = new PasswordHasher<ApplicationUser>();
            user1.PasswordHash = passwordHash1.HashPassword(user1, "Test1*");
            modelBuilder.Entity<ApplicationUser>().HasData(user1);

            ApplicationUser user2 = new ApplicationUser
            {
                FirstName = "Ronaldo",
                LastName = "McDonaldo",
                StreetAddress = "456 Long Street",
                UserName = "ron@test.com",
                NormalizedUserName = "RON@TEST.COM",
                Email = "ron@test.com",
                NormalizedEmail = "RON@TEST.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash2 = new PasswordHasher<ApplicationUser>();
            user2.PasswordHash = passwordHash2.HashPassword(user2, "Test1*");
            modelBuilder.Entity<ApplicationUser>().HasData(user2);

            ApplicationUser user3 = new ApplicationUser
            {
                FirstName = "Lauren-Jane",
                LastName = "Belle",
                StreetAddress = "789 Robert E. Lee Blvd.",
                UserName = "lj@test.com",
                NormalizedUserName = "LJ@TEST.COM",
                Email = "lj@test.com",
                NormalizedEmail = "LJ@TEST.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash3 = new PasswordHasher<ApplicationUser>();
            user3.PasswordHash = passwordHash3.HashPassword(user3, "Test1*");
            modelBuilder.Entity<ApplicationUser>().HasData(user3);


            modelBuilder.Entity<PaymentType> ().HasData (
                new PaymentType() {
                    PaymentTypeId = 1,
                    UserId = user.Id,
                    Description = "American Express",
                    AccountNumber = "86753095551212"
                },
                new PaymentType() {
                    PaymentTypeId = 2,
                    UserId = user.Id,
                    Description = "Discover",
                    AccountNumber = "4102948572991"
                },
                 new PaymentType()
                 {
                     PaymentTypeId = 3,
                     UserId = user1.Id,
                     Description = "American Express",
                     AccountNumber = "6469382038410084"
                 },
                new PaymentType()
                {
                    PaymentTypeId = 4,
                    UserId = user1.Id,
                    Description = "Discover",
                    AccountNumber = "9650917385012"
                },
                new PaymentType()
                {
                    PaymentTypeId = 5,
                    UserId = user2.Id,
                    Description = "Discover",
                    AccountNumber = "12345678910"
                }
            );
            modelBuilder.Entity<ProductType>().HasData(
                new ProductType()
                {
                    ProductTypeId = 1,
                    Label = "Electronics"
                },
                new ProductType()
                {
                    ProductTypeId = 2,
                    Label = "Books"
                },
                new ProductType()
                {
                    ProductTypeId = 3,
                    Label = "Toys"
                },
                new ProductType()
                {
                    ProductTypeId = 4,
                    Label = "Tools"
                },
                new ProductType()
                {
                    ProductTypeId = 5,
                    Label = "Vehicles"
                },
                new ProductType()
                {
                    ProductTypeId = 6,
                    Label = "Video Games"
                },
                new ProductType()
                {
                    ProductTypeId = 7,
                    Label = "Other"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    DateCreated = DateTime.MinValue,
                    Title = "Samsung TV",
                    Description = "65 Inch OLED Curved 3d VR SmartTV",
                    Price = 9999.0,
                    Quantity = 1,
                    City = "Seoul",
                    ProductTypeId = 1,
                    UserId = user2.Id
                },
                new Product()
                {
                    ProductId = 2,
                    DateCreated = DateTime.Now,
                    Title = "Nintendo XPlayStation 7201",
                    Description = "The ULTIMATE gaming machine",
                    Price = 499.99,
                    Quantity = 34,
                    City = "Nashville",
                    ProductTypeId = 1,
                    UserId = user3.Id
                },
                new Product()
                {
                    ProductId = 3,
                    DateCreated = DateTime.MinValue,
                    Title = "Smart Light",
                    Description = "It's a light bulb, but smart.",
                    Price = 20.99,
                    Quantity = 46,
                    City = "Nashville",
                    ProductTypeId = 1,
                    UserId = user.Id
                },
                new Product()
                {
                    ProductId = 4,
                    DateCreated = DateTime.MinValue,
                    Title = "Sony Alpha 7-111",
                    Description = "A camera that has no mirrors.",
                    Price = 2418.00,
                    Quantity = 7,
                    City = "",
                    ProductTypeId = 1,
                    UserId = user3.Id,
                },
                new Product()
                {
                    ProductId = 5,
                    DateCreated = DateTime.Now,
                    Title = "Harry Potter and the Philospher's Stone",
                    Description = "'Yer a wizard Harry'",
                    Price = 15.99,
                    Quantity = 1,
                    City = "Seoul",
                    ProductTypeId = 2,
                    UserId = user2.Id
                },
                new Product()
                {
                    ProductId = 6,
                    DateCreated = DateTime.MaxValue,
                    Title = "The OG Philospher's Stone",
                    Description = "Turns lead into gold and grants immortality. Also kinda ugly",
                    Price = 3.53,
                    Quantity = 1,
                    City = "Camelot",
                    ProductTypeId = 7,
                    UserId = user.Id
                },
                new Product()
                {
                    ProductId = 7,
                    DateCreated = DateTime.Now,
                    Title = "Rubber Duck",
                    Description = "The source of infinite programming knowledge",
                    Price = 7.99,
                    Quantity = 26,
                    City = "",
                    ProductTypeId = 3,
                    UserId = user3.Id
                },
                new Product()
                {
                    ProductId = 8,
                    DateCreated = DateTime.MinValue,
                    Title = "Light Saber",
                    Description = "A more elegant weapon from a more civilized time",
                    Price = 2317.03,
                    Quantity = 1,
                    City = "Mos Eisley",
                    ProductTypeId = 4,
                    UserId = user2.Id
                },
                new Product()
                {
                    ProductId = 9,
                    DateCreated = DateTime.Now,
                    Title = "Tesla Model 3",
                    Description = "Ride the Lightning",
                    Price = 35000.00,
                    Quantity = 50000,
                    City = "Fremont",
                    ProductTypeId = 5,
                    UserId = user.Id
                },
                new Product()
                {
                    ProductId = 10,
                    DateCreated = DateTime.MaxValue,
                    Title = "HalfLife 3",
                    Description = "Greatest game never made",
                    Price = 29.99,
                    Quantity = 12,
                    City = "",
                    ProductTypeId = 1,
                    UserId = user.Id
                },
                new Product()
                {
                    ProductId = 11,
                    DateCreated = DateTime.Now,
                    Title = "Harry Potter and the Chamber of Secrets",
                    Description = "A large pile of ash",
                    Price = 15.99,
                    Quantity = 10,
                    City = "",
                    ProductTypeId = 2,
                    UserId = user2.Id
                },
                new Product()
                {
                    ProductId = 12,
                    DateCreated = DateTime.MinValue,
                    Title = "Mjolnir",
                    Description = "Only one who is worth may wield me.",
                    Price = 115.99,
                    Quantity = 1,
                    City = "Asgard",
                    ProductTypeId = 4,
                    UserId = user.Id
                },
                new Product()
                {
                    ProductId = 13,
                    DateCreated = DateTime.Now,
                    Title = "Yellow Submarine",
                    Description = "We all live in it",
                    Price = 1235.99,
                    Quantity = 1,
                    City = "Liverpool",
                    ProductTypeId = 5,
                    UserId = user3.Id
                },
                new Product()
                {
                    ProductId = 14,
                    DateCreated = DateTime.Now,
                    Title = "Mr. & Mrs. Potato Head Anniversary Set",
                    Description = "What a lumpy couple",
                    Price = 55.99,
                    Quantity = 65,
                    City = "Nashville",
                    ProductTypeId = 4,
                    UserId = user2.Id
                },
                new Product()
                {
                    ProductId = 15,
                    DateCreated = DateTime.Now,
                    Title = "Nerf Gun",
                    Description = "You'll loose a dart immediately",
                    Price = 27.99,
                    Quantity = 18,
                    City = "",
                    ProductTypeId = 4,
                    UserId = user.Id
                },
                new Product()
                {
                    ProductId = 16,
                    DateCreated = DateTime.MinValue,
                    Title = "Vibranium Fidget Spinner",
                    Description = "SpinZ forever",
                    Price = 67.99,
                    Quantity = 42,
                    City = "Birnin Zana",
                    ProductTypeId = 3,
                    UserId = user2.Id
                },
                new Product()
                {
                    ProductId = 17,
                    DateCreated = DateTime.MaxValue,
                    Title = "The Doors of Stone",
                    Description = "Using words to talk of words is like using a pencil to draw a picture of itself, on itself.",
                    Price = 25.99,
                    Quantity = 1,
                    City = "",
                    ProductTypeId = 2,
                    UserId = user2.Id
                },
                new Product()
                {
                    ProductId = 18,
                    DateCreated = DateTime.Now,
                    Title = "The Rook",
                    Description = "The greatest hook of any book, so take a look and you'll be shook.",
                    Price = 21.99,
                    Quantity = 4,
                    City = "Nashville",
                    ProductTypeId = 2,
                    UserId = user2.Id
                },
                new Product()
                {
                    ProductId = 19,
                    DateCreated = DateTime.MaxValue,
                    Title = "The Necronomicon",
                    Description = "The call of Cthulu. Nameless horrors of elder gods and unspeakable blasphemies. (Bound in Human skin!)",
                    Price = 25.99,
                    Quantity = 1,
                    City = "Nashville",
                    ProductTypeId = 2,
                    UserId = user2.Id
                },
                new Product()
                {
                    ProductId = 20,
                    DateCreated = DateTime.MaxValue,
                    Title = "Ender's Game",
                    Description = "A mormon author representing diversity (but then he changed his mind?).",
                    Price = 6.99,
                    Quantity = 14,
                    City = "",
                    ProductTypeId = 2,
                    UserId = user.Id
                },
                new Product()
                {
                    ProductId = 21,
                    DateCreated = DateTime.MaxValue,
                    Title = "The Shining",
                    Description = "Heeeeeere's Johnny.",
                    Price = 8.99,
                    Quantity = 1,
                    City = "",
                    ProductTypeId = 2,
                    UserId = user.Id
                }
                );
            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    OrderId = 1,
                    DateCreated = DateTime.MinValue,
                    DateCompleted = DateTime.Now,
                    PaymentTypeId = 1,
                    UserId = user.Id
                },
                new Order()
                {
                    OrderId = 2,
                    DateCreated = DateTime.Now,
                    PaymentTypeId = null,
                    UserId = user.Id
                });
        }
    }
}