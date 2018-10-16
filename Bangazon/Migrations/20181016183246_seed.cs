using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    PaymentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Description = table.Column<string>(maxLength: 25, nullable: false),
                    AccountNumber = table.Column<string>(maxLength: 20, nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.PaymentTypeId);
                    table.ForeignKey(
                        name: "FK_PaymentType_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Title = table.Column<string>(maxLength: 55, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    DateCompleted = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<string>(nullable: false),
                    PaymentTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_PaymentType_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentType",
                        principalColumn: "PaymentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrderProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => x.OrderProductId);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "29529141-0c77-4379-a5ed-398fa265465c", 0, "583eacf3-fada-4185-8276-cf6088b7a910", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEEVQ0NEtsfT0AC3pDH3PlgDSfSrhHiKyM+ByY7lE2TDPInGBduan9vRQPsdo8D2DBg==", null, false, "1f89846e-f3dd-4d33-984f-afebb74ea733", "123 Infinity Way", false, "admin@admin.com" },
                    { "dae864e7-c5ed-4217-87ec-6424b8e413f1", 0, "ffd2a7ce-7928-46b4-b6dc-17a960686120", "test@test.com", true, "Test", "Smith", false, null, "TEST@TEST.COM", "TEST@TEST.COM", "AQAAAAEAACcQAAAAEPH0HR7/l/7zZJs+51HK70HK1yT+1BS8TSEK514z/CmYd851Vcp2HPj1BNPXxZmgpg==", null, false, "2d8e9990-0c27-4f21-873d-3538ccf72c85", "123 Main Way", false, "test@test.com" },
                    { "8f4addd4-d341-40f6-b881-c1daa2ba10a3", 0, "646f0d64-1702-4c9f-bb34-be83c8c02c07", "ron@test.com", true, "Ronaldo", "McDonaldo", false, null, "RON@TEST.COM", "RON@TEST.COM", "AQAAAAEAACcQAAAAEKFh8OrPh82b0VEIEnUwu70+Bamc4m/MHQH39aQ7s6Haw6lnbrsVD3M3wu6hwtQJ0w==", null, false, "16ecec98-c735-4bff-82c8-f27595a67b1a", "456 Long Street", false, "ron@test.com" },
                    { "e1377b9b-6094-4366-bfdd-f4707cc1ff43", 0, "546ebc29-26d1-442a-901c-d9f46fd3c1f4", "lj@test.com", true, "Lauren-Jane", "Belle", false, null, "LJ@TEST.COM", "LJ@TEST.COM", "AQAAAAEAACcQAAAAEH2LhzRTqnJrl+WZld/h3HjpJSSuI12dqm4aB3FmNk2Yv+KZWY60o6ICFhKtQLL07Q==", null, false, "620ecd15-3924-4c50-bf52-87b182d3aebd", "789 Robert E. Lee Blvd.", false, "lj@test.com" }
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "ProductTypeId", "Label" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Books" },
                    { 3, "Toys" },
                    { 4, "Tools" },
                    { 5, "Vehicles" },
                    { 6, "Video Games" },
                    { 7, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "DateCompleted", "DateCreated", "PaymentTypeId", "UserId" },
                values: new object[] { 2, null, new DateTime(2018, 10, 16, 13, 32, 46, 267, DateTimeKind.Local), null, "29529141-0c77-4379-a5ed-398fa265465c" });

            migrationBuilder.InsertData(
                table: "PaymentType",
                columns: new[] { "PaymentTypeId", "AccountNumber", "DateCreated", "Description", "UserId" },
                values: new object[,]
                {
                    { 1, "86753095551212", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Express", "29529141-0c77-4379-a5ed-398fa265465c" },
                    { 2, "4102948572991", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discover", "29529141-0c77-4379-a5ed-398fa265465c" },
                    { 3, "6469382038410084", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Express", "dae864e7-c5ed-4217-87ec-6424b8e413f1" },
                    { 4, "9650917385012", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discover", "dae864e7-c5ed-4217-87ec-6424b8e413f1" },
                    { 5, "12345678910", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discover", "8f4addd4-d341-40f6-b881-c1daa2ba10a3" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "City", "DateCreated", "Description", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[,]
                {
                    { 9, "Fremont", new DateTime(2018, 10, 16, 13, 32, 46, 266, DateTimeKind.Local), "Ride the Lightning", 35000.0, 5, 50000, "Tesla Model 3", "29529141-0c77-4379-a5ed-398fa265465c" },
                    { 15, "", new DateTime(2018, 10, 16, 13, 32, 46, 266, DateTimeKind.Local), "You'll loose a dart immediately", 27.99, 4, 18, "Nerf Gun", "29529141-0c77-4379-a5ed-398fa265465c" },
                    { 14, "Nashville", new DateTime(2018, 10, 16, 13, 32, 46, 266, DateTimeKind.Local), "What a lumpy couple", 55.99, 4, 65, "Mr. & Mrs. Potato Head Anniversary Set", "8f4addd4-d341-40f6-b881-c1daa2ba10a3" },
                    { 12, "Asgard", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Only one who is worth may wield me.", 115.99, 4, 1, "Mjolnir", "29529141-0c77-4379-a5ed-398fa265465c" },
                    { 8, "Mos Eisley", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A more elegant weapon from a more civilized time", 2317.03, 4, 1, "Light Saber", "8f4addd4-d341-40f6-b881-c1daa2ba10a3" },
                    { 16, "Birnin Zana", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SpinZ forever", 67.99, 3, 42, "Vibranium Fidget Spinner", "8f4addd4-d341-40f6-b881-c1daa2ba10a3" },
                    { 7, "", new DateTime(2018, 10, 16, 13, 32, 46, 266, DateTimeKind.Local), "The source of infinite programming knowledge", 7.99, 3, 26, "Rubber Duck", "e1377b9b-6094-4366-bfdd-f4707cc1ff43" },
                    { 21, "", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), "Heeeeeere's Johnny.", 8.99, 2, 1, "The Shining", "29529141-0c77-4379-a5ed-398fa265465c" },
                    { 20, "", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), "A mormon author representing diversity (but then he changed his mind?).", 6.99, 2, 14, "Ender's Game", "29529141-0c77-4379-a5ed-398fa265465c" },
                    { 17, "", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), "Using words to talk of words is like using a pencil to draw a picture of itself, on itself.", 25.99, 2, 1, "The Doors of Stone", "8f4addd4-d341-40f6-b881-c1daa2ba10a3" },
                    { 18, "Nashville", new DateTime(2018, 10, 16, 13, 32, 46, 266, DateTimeKind.Local), "The greatest hook of any book, so take a look and you'll be shook.", 21.99, 2, 4, "The Rook", "8f4addd4-d341-40f6-b881-c1daa2ba10a3" },
                    { 13, "Liverpool", new DateTime(2018, 10, 16, 13, 32, 46, 266, DateTimeKind.Local), "We all live in it", 1235.99, 5, 1, "Yellow Submarine", "e1377b9b-6094-4366-bfdd-f4707cc1ff43" },
                    { 11, "", new DateTime(2018, 10, 16, 13, 32, 46, 266, DateTimeKind.Local), "A large pile of ash", 15.99, 2, 10, "Harry Potter and the Chamber of Secrets", "8f4addd4-d341-40f6-b881-c1daa2ba10a3" },
                    { 5, "Seoul", new DateTime(2018, 10, 16, 13, 32, 46, 266, DateTimeKind.Local), "'Yer a wizard Harry'", 15.99, 2, 1, "Harry Potter and the Philospher's Stone", "8f4addd4-d341-40f6-b881-c1daa2ba10a3" },
                    { 10, "", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), "Greatest game never made", 29.99, 1, 12, "HalfLife 3", "29529141-0c77-4379-a5ed-398fa265465c" },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A camera that has no mirrors.", 2418.0, 1, 7, "Sony Alpha 7-111", "e1377b9b-6094-4366-bfdd-f4707cc1ff43" },
                    { 3, "Nashville", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It's a light bulb, but smart.", 20.99, 1, 46, "Smart Light", "29529141-0c77-4379-a5ed-398fa265465c" },
                    { 2, "Nashville", new DateTime(2018, 10, 16, 13, 32, 46, 263, DateTimeKind.Local), "The ULTIMATE gaming machine", 499.99, 1, 34, "Nintendo XPlayStation 7201", "e1377b9b-6094-4366-bfdd-f4707cc1ff43" },
                    { 1, "Seoul", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "65 Inch OLED Curved 3d VR SmartTV", 9999.0, 1, 1, "Samsung TV", "8f4addd4-d341-40f6-b881-c1daa2ba10a3" },
                    { 19, "Nashville", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), "The call of Cthulu. Nameless horrors of elder gods and unspeakable blasphemies. (Bound in Human skin!)", 25.99, 2, 1, "The Necronomicon", "8f4addd4-d341-40f6-b881-c1daa2ba10a3" },
                    { 6, "Camelot", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified), "Turns lead into gold and grants immortality. Also kinda ugly", 3.53, 7, 1, "The OG Philospher's Stone", "29529141-0c77-4379-a5ed-398fa265465c" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "DateCompleted", "DateCreated", "PaymentTypeId", "UserId" },
                values: new object[] { 1, new DateTime(2018, 10, 16, 13, 32, 46, 267, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "29529141-0c77-4379-a5ed-398fa265465c" });

            migrationBuilder.InsertData(
                table: "OrderProduct",
                columns: new[] { "OrderProductId", "OrderId", "ProductId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentTypeId",
                table: "Order",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentType_UserId",
                table: "PaymentType",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeId",
                table: "Product",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserId",
                table: "Product",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
