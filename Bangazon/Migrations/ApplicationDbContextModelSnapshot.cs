﻿// <auto-generated />
using System;
using Bangazon.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bangazon.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bangazon.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("StreetAddress")
                        .IsRequired();

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6", AccessFailedCount = 0, ConcurrencyStamp = "4c6fee06-b406-4d75-9ce5-83c5de701b68", Email = "admin@admin.com", EmailConfirmed = true, FirstName = "admin", LastName = "admin", LockoutEnabled = false, NormalizedEmail = "ADMIN@ADMIN.COM", NormalizedUserName = "ADMIN@ADMIN.COM", PasswordHash = "AQAAAAEAACcQAAAAEBXnrHnC/DNUpj+sHuuJJnf36+Jvzy5ofkyC9XHWGTNsGHbqbbpZTNKyYZRXn/NePg==", PhoneNumberConfirmed = false, SecurityStamp = "09f3f967-a7ba-4a9b-b86f-9d2e0318790d", StreetAddress = "123 Infinity Way", TwoFactorEnabled = false, UserName = "admin@admin.com" },
                        new { Id = "eedadbc9-acb8-4612-b948-a2eeaf73ee1a", AccessFailedCount = 0, ConcurrencyStamp = "2f5cf1cc-2770-4901-b413-25aa8cce7c68", Email = "test@test.com", EmailConfirmed = true, FirstName = "Test", LastName = "Smith", LockoutEnabled = false, NormalizedEmail = "TEST@TEST.COM", NormalizedUserName = "TEST@TEST.COM", PasswordHash = "AQAAAAEAACcQAAAAEHYpLB3sq/5VOFwEvD3+Mp6r0pTmPlqgjsEMOpmtPsLyEJnEgSGl+OBd6usWKGuhhw==", PhoneNumberConfirmed = false, SecurityStamp = "4faf41fc-9493-4f37-9492-09a03003c427", StreetAddress = "123 Main Way", TwoFactorEnabled = false, UserName = "test@test.com" },
                        new { Id = "46f35a2f-c6ed-46f9-aa27-c01398343051", AccessFailedCount = 0, ConcurrencyStamp = "e68a82cf-917c-4e5c-989c-26c1aa58c389", Email = "ron@test.com", EmailConfirmed = true, FirstName = "Ronaldo", LastName = "McDonaldo", LockoutEnabled = false, NormalizedEmail = "RON@TEST.COM", NormalizedUserName = "RON@TEST.COM", PasswordHash = "AQAAAAEAACcQAAAAEDfoAI+tbb8WJI20ZWRZPlZpH9KuxtjyARcbKXOa32dFCtOT0xciR9/fQ4neY8wI+w==", PhoneNumberConfirmed = false, SecurityStamp = "9d0165b4-7d71-4b25-b5bf-601b5fcf97dd", StreetAddress = "456 Long Street", TwoFactorEnabled = false, UserName = "ron@test.com" },
                        new { Id = "2d47849c-4efe-4547-b3e6-2e22266a8472", AccessFailedCount = 0, ConcurrencyStamp = "89a29798-e05b-428d-ae9c-227d2d2a1326", Email = "lj@test.com", EmailConfirmed = true, FirstName = "Lauren-Jane", LastName = "Belle", LockoutEnabled = false, NormalizedEmail = "LJ@TEST.COM", NormalizedUserName = "LJ@TEST.COM", PasswordHash = "AQAAAAEAACcQAAAAEGxP7fzaMazPl9mQBcslcLK64Tcj5mCYZR1EglZFxO02nGZSiYi8zs4G5UCLYecRdQ==", PhoneNumberConfirmed = false, SecurityStamp = "0d32877b-b3c3-4573-868a-4f7e5ab3d3d5", StreetAddress = "789 Robert E. Lee Blvd.", TwoFactorEnabled = false, UserName = "lj@test.com" }
                    );
                });

            modelBuilder.Entity("Bangazon.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateCompleted");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("PaymentTypeId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("OrderId");

                    b.HasIndex("PaymentTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");

                    b.HasData(
                        new { OrderId = 1, DateCompleted = new DateTime(2018, 10, 16, 13, 28, 0, 144, DateTimeKind.Local), DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PaymentTypeId = 1, UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" },
                        new { OrderId = 2, DateCreated = new DateTime(2018, 10, 16, 13, 28, 0, 144, DateTimeKind.Local), UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" }
                    );
                });

            modelBuilder.Entity("Bangazon.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.HasKey("OrderProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");

                    b.HasData(
                        new { OrderProductId = 1, OrderId = 1, ProductId = 1 }
                    );
                });

            modelBuilder.Entity("Bangazon.Models.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("PaymentTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("PaymentType");

                    b.HasData(
                        new { PaymentTypeId = 1, AccountNumber = "86753095551212", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "American Express", UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" },
                        new { PaymentTypeId = 2, AccountNumber = "4102948572991", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Discover", UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" },
                        new { PaymentTypeId = 3, AccountNumber = "6469382038410084", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "American Express", UserId = "eedadbc9-acb8-4612-b948-a2eeaf73ee1a" },
                        new { PaymentTypeId = 4, AccountNumber = "9650917385012", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Discover", UserId = "eedadbc9-acb8-4612-b948-a2eeaf73ee1a" },
                        new { PaymentTypeId = 5, AccountNumber = "12345678910", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Discover", UserId = "46f35a2f-c6ed-46f9-aa27-c01398343051" }
                    );
                });

            modelBuilder.Entity("Bangazon.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<double>("Price");

                    b.Property<int>("ProductTypeId");

                    b.Property<int>("Quantity");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Product");

                    b.HasData(
                        new { ProductId = 1, City = "Seoul", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "65 Inch OLED Curved 3d VR SmartTV", Price = 9999.0, ProductTypeId = 1, Quantity = 1, Title = "Samsung TV", UserId = "46f35a2f-c6ed-46f9-aa27-c01398343051" },
                        new { ProductId = 2, City = "Nashville", DateCreated = new DateTime(2018, 10, 16, 13, 28, 0, 142, DateTimeKind.Local), Description = "The ULTIMATE gaming machine", Price = 499.99, ProductTypeId = 1, Quantity = 34, Title = "Nintendo XPlayStation 7201", UserId = "2d47849c-4efe-4547-b3e6-2e22266a8472" },
                        new { ProductId = 3, City = "Nashville", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "It's a light bulb, but smart.", Price = 20.99, ProductTypeId = 1, Quantity = 46, Title = "Smart Light", UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" },
                        new { ProductId = 4, City = "", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "A camera that has no mirrors.", Price = 2418.0, ProductTypeId = 1, Quantity = 7, Title = "Sony Alpha 7-111", UserId = "2d47849c-4efe-4547-b3e6-2e22266a8472" },
                        new { ProductId = 5, City = "Seoul", DateCreated = new DateTime(2018, 10, 16, 13, 28, 0, 144, DateTimeKind.Local), Description = "'Yer a wizard Harry'", Price = 15.99, ProductTypeId = 2, Quantity = 1, Title = "Harry Potter and the Philospher's Stone", UserId = "46f35a2f-c6ed-46f9-aa27-c01398343051" },
                        new { ProductId = 6, City = "Camelot", DateCreated = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), Description = "Turns lead into gold and grants immortality. Also kinda ugly", Price = 3.53, ProductTypeId = 7, Quantity = 1, Title = "The OG Philospher's Stone", UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" },
                        new { ProductId = 7, City = "", DateCreated = new DateTime(2018, 10, 16, 13, 28, 0, 144, DateTimeKind.Local), Description = "The source of infinite programming knowledge", Price = 7.99, ProductTypeId = 3, Quantity = 26, Title = "Rubber Duck", UserId = "2d47849c-4efe-4547-b3e6-2e22266a8472" },
                        new { ProductId = 8, City = "Mos Eisley", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "A more elegant weapon from a more civilized time", Price = 2317.03, ProductTypeId = 4, Quantity = 1, Title = "Light Saber", UserId = "46f35a2f-c6ed-46f9-aa27-c01398343051" },
                        new { ProductId = 9, City = "Fremont", DateCreated = new DateTime(2018, 10, 16, 13, 28, 0, 144, DateTimeKind.Local), Description = "Ride the Lightning", Price = 35000.0, ProductTypeId = 5, Quantity = 50000, Title = "Tesla Model 3", UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" },
                        new { ProductId = 10, City = "", DateCreated = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), Description = "Greatest game never made", Price = 29.99, ProductTypeId = 1, Quantity = 12, Title = "HalfLife 3", UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" },
                        new { ProductId = 11, City = "", DateCreated = new DateTime(2018, 10, 16, 13, 28, 0, 144, DateTimeKind.Local), Description = "A large pile of ash", Price = 15.99, ProductTypeId = 2, Quantity = 10, Title = "Harry Potter and the Chamber of Secrets", UserId = "46f35a2f-c6ed-46f9-aa27-c01398343051" },
                        new { ProductId = 12, City = "Asgard", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "Only one who is worth may wield me.", Price = 115.99, ProductTypeId = 4, Quantity = 1, Title = "Mjolnir", UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" },
                        new { ProductId = 13, City = "Liverpool", DateCreated = new DateTime(2018, 10, 16, 13, 28, 0, 144, DateTimeKind.Local), Description = "We all live in it", Price = 1235.99, ProductTypeId = 5, Quantity = 1, Title = "Yellow Submarine", UserId = "2d47849c-4efe-4547-b3e6-2e22266a8472" },
                        new { ProductId = 14, City = "Nashville", DateCreated = new DateTime(2018, 10, 16, 13, 28, 0, 144, DateTimeKind.Local), Description = "What a lumpy couple", Price = 55.99, ProductTypeId = 4, Quantity = 65, Title = "Mr. & Mrs. Potato Head Anniversary Set", UserId = "46f35a2f-c6ed-46f9-aa27-c01398343051" },
                        new { ProductId = 15, City = "", DateCreated = new DateTime(2018, 10, 16, 13, 28, 0, 144, DateTimeKind.Local), Description = "You'll loose a dart immediately", Price = 27.99, ProductTypeId = 4, Quantity = 18, Title = "Nerf Gun", UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" },
                        new { ProductId = 16, City = "Birnin Zana", DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Description = "SpinZ forever", Price = 67.99, ProductTypeId = 3, Quantity = 42, Title = "Vibranium Fidget Spinner", UserId = "46f35a2f-c6ed-46f9-aa27-c01398343051" },
                        new { ProductId = 17, City = "", DateCreated = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), Description = "Using words to talk of words is like using a pencil to draw a picture of itself, on itself.", Price = 25.99, ProductTypeId = 2, Quantity = 1, Title = "The Doors of Stone", UserId = "46f35a2f-c6ed-46f9-aa27-c01398343051" },
                        new { ProductId = 18, City = "Nashville", DateCreated = new DateTime(2018, 10, 16, 13, 28, 0, 144, DateTimeKind.Local), Description = "The greatest hook of any book, so take a look and you'll be shook.", Price = 21.99, ProductTypeId = 2, Quantity = 4, Title = "The Rook", UserId = "46f35a2f-c6ed-46f9-aa27-c01398343051" },
                        new { ProductId = 19, City = "Nashville", DateCreated = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), Description = "The call of Cthulu. Nameless horrors of elder gods and unspeakable blasphemies. (Bound in Human skin!)", Price = 25.99, ProductTypeId = 2, Quantity = 1, Title = "The Necronomicon", UserId = "46f35a2f-c6ed-46f9-aa27-c01398343051" },
                        new { ProductId = 20, City = "", DateCreated = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), Description = "A mormon author representing diversity (but then he changed his mind?).", Price = 6.99, ProductTypeId = 2, Quantity = 14, Title = "Ender's Game", UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" },
                        new { ProductId = 21, City = "", DateCreated = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), Description = "Heeeeeere's Johnny.", Price = 8.99, ProductTypeId = 2, Quantity = 1, Title = "The Shining", UserId = "9dbca40e-64b8-45c4-a6e1-aaadf63e21b6" }
                    );
                });

            modelBuilder.Entity("Bangazon.Models.ProductType", b =>
                {
                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("ProductTypeId");

                    b.ToTable("ProductType");

                    b.HasData(
                        new { ProductTypeId = 1, Label = "Electronics" },
                        new { ProductTypeId = 2, Label = "Books" },
                        new { ProductTypeId = 3, Label = "Toys" },
                        new { ProductTypeId = 4, Label = "Tools" },
                        new { ProductTypeId = 5, Label = "Vehicles" },
                        new { ProductTypeId = 6, Label = "Video Games" },
                        new { ProductTypeId = 7, Label = "Other" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Bangazon.Models.Order", b =>
                {
                    b.HasOne("Bangazon.Models.PaymentType", "PaymentType")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentTypeId");

                    b.HasOne("Bangazon.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bangazon.Models.OrderProduct", b =>
                {
                    b.HasOne("Bangazon.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Bangazon.Models.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bangazon.Models.PaymentType", b =>
                {
                    b.HasOne("Bangazon.Models.ApplicationUser", "User")
                        .WithMany("PaymentTypes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bangazon.Models.Product", b =>
                {
                    b.HasOne("Bangazon.Models.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bangazon.Models.ApplicationUser", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Bangazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Bangazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bangazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Bangazon.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
