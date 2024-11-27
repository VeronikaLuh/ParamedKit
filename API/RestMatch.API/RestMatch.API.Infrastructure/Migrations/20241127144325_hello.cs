using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class hello : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuisines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuisines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    CountOfRate = table.Column<int>(type: "int", nullable: false),
                    LowerPrice = table.Column<int>(type: "int", nullable: false),
                    UpperPrice = table.Column<int>(type: "int", nullable: false),
                    OpeningTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ClosingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantCriterias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Italian = table.Column<double>(type: "float", nullable: false),
                    CountOfRateItalian = table.Column<int>(type: "int", nullable: false),
                    Chinese = table.Column<double>(type: "float", nullable: false),
                    CountOfRateChinese = table.Column<int>(type: "int", nullable: false),
                    Mexican = table.Column<double>(type: "float", nullable: false),
                    CountOfRateMexican = table.Column<int>(type: "int", nullable: false),
                    Japanese = table.Column<double>(type: "float", nullable: false),
                    CountOfRateJapanese = table.Column<int>(type: "int", nullable: false),
                    Indian = table.Column<double>(type: "float", nullable: false),
                    CountOfRateIndian = table.Column<int>(type: "int", nullable: false),
                    French = table.Column<double>(type: "float", nullable: false),
                    CountOfRateFrench = table.Column<int>(type: "int", nullable: false),
                    Mediterranean = table.Column<double>(type: "float", nullable: false),
                    CountOfRateMediterranean = table.Column<int>(type: "int", nullable: false),
                    American = table.Column<double>(type: "float", nullable: false),
                    CountOfRateAmerican = table.Column<int>(type: "int", nullable: false),
                    Greek = table.Column<double>(type: "float", nullable: false),
                    CountOfRateGreek = table.Column<int>(type: "int", nullable: false),
                    Ukrainian = table.Column<double>(type: "float", nullable: false),
                    CountOfRateUkrainian = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantCriterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantCriterias_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantCuisines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantCuisines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantCuisines_Cuisines_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Cuisines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantCuisines_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantImageUrls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantImageUrls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantImageUrls_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favourites_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favourites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCriterias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Italian = table.Column<double>(type: "float", nullable: false),
                    CountOfRateItalian = table.Column<int>(type: "int", nullable: false),
                    Chinese = table.Column<double>(type: "float", nullable: false),
                    CountOfRateChinese = table.Column<int>(type: "int", nullable: false),
                    Mexican = table.Column<double>(type: "float", nullable: false),
                    CountOfRateMexican = table.Column<int>(type: "int", nullable: false),
                    Japanese = table.Column<double>(type: "float", nullable: false),
                    CountOfRateJapanese = table.Column<int>(type: "int", nullable: false),
                    Indian = table.Column<double>(type: "float", nullable: false),
                    CountOfRateIndian = table.Column<int>(type: "int", nullable: false),
                    French = table.Column<double>(type: "float", nullable: false),
                    CountOfRateFrench = table.Column<int>(type: "int", nullable: false),
                    Mediterranean = table.Column<double>(type: "float", nullable: false),
                    CountOfRateMediterranean = table.Column<int>(type: "int", nullable: false),
                    American = table.Column<double>(type: "float", nullable: false),
                    CountOfRateAmerican = table.Column<int>(type: "int", nullable: false),
                    Greek = table.Column<double>(type: "float", nullable: false),
                    CountOfRateGreek = table.Column<int>(type: "int", nullable: false),
                    Ukrainian = table.Column<double>(type: "float", nullable: false),
                    CountOfRateUkrainian = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCriterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCriterias_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSelectedCriterias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CuisineId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSelectedCriterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSelectedCriterias_Cuisines_CuisineId",
                        column: x => x.CuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSelectedCriterias_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cuisines",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Italian" },
                    { 2, "Chinese" },
                    { 3, "Mexican" },
                    { 4, "Japanese" },
                    { 5, "Indian" },
                    { 6, "French" },
                    { 7, "Mediterranean" },
                    { 8, "American" },
                    { 9, "Greek" },
                    { 10, "Ukrainian" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "AboutText", "Address", "City", "ClosingTime", "CountOfRate", "Country", "CreatedAt", "LowerPrice", "MenuUrl", "ModifiedAt", "Name", "OpeningTime", "PhoneNumber", "Rating", "UpperPrice" },
                values: new object[,]
                {
                    { 1, "A cozy restaurant in the heart of the forest, offering seasonal dishes.", "123 Forest Lane, Oakland", "Oakland", new TimeSpan(0, 22, 0, 0, 0), 0, "Fictivia", new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4469), 20, "https://www.goldenoak.com/menu", new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4473), "The Golden Oak", new TimeSpan(0, 10, 0, 0, 0), "+1 234-567-8901", 4.2999999999999998, 50 },
                    { 2, "Serving fusion dishes with a magical twist.", "45 Crescent Drive, Moonlight", "Moonlight", new TimeSpan(0, 23, 0, 0, 0), 0, "Etherea", new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4473), 30, "https://www.lunabistro.com/menu", new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4474), "Luna’s Bistro", new TimeSpan(0, 11, 0, 0, 0), "+2 345-678-9012", 4.7000000000000002, 75 },
                    { 3, "A steakhouse specializing in rare cuts and wines.", "89 Ironwood Avenue, Redstone", "Redstone", new TimeSpan(0, 23, 30, 0, 0), 0, "Fictivia", new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4474), 50, "https://www.crimsonbarrel.com/menu", new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4474), "Crimson Barrel", new TimeSpan(0, 12, 0, 0, 0), "+3 567-890-1234", 4.5, 150 },
                    { 4, "Upscale dining with an elegant atmosphere.", "25 Sparkling Rd, Glimmerstone", "Glimmerstone", new TimeSpan(0, 20, 0, 0, 0), 0, "Arcadia", new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4475), 40, "https://www.velvetspoon.com/menu", new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4475), "The Velvet Spoon", new TimeSpan(0, 8, 30, 0, 0), "+4 678-901-2345", 4.2000000000000002, 80 },
                    { 5, "Fresh seafood and grill dishes with an ocean view.", "101 Beachfront Blvd, Oceanview", "Oceanview", new TimeSpan(0, 21, 30, 0, 0), 0, "Nautica", new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4475), 25, "https://www.seasidegrill.com/menu", new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4476), "Seaside Grill", new TimeSpan(0, 9, 0, 0, 0), "+5 890-123-4567", 4.5999999999999996, 60 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RoleName" },
                values: new object[,]
                {
                    { 1, null, null, "User" },
                    { 2, null, null, "Moderator" },
                    { 3, null, null, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantCuisines",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4814), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4815), 1, 3 },
                    { 2, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4817), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4817), 1, 10 },
                    { 3, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4827), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4828), 2, 1 },
                    { 4, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4829), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4829), 2, 9 },
                    { 5, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4839), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4839), 3, 2 },
                    { 6, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4841), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4841), 3, 10 },
                    { 7, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4850), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4850), 4, 5 },
                    { 8, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4858), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4858), 5, 7 },
                    { 9, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4859), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4859), 5, 8 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantImageUrls",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4584), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4585), 1, "http://example.com/the_golden_oak0" },
                    { 2, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4623), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4624), 2, "http://example.com/luna’s_bistro0" },
                    { 3, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4627), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4627), 3, "http://example.com/crimson_barrel0" },
                    { 4, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4665), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4666), 3, "http://example.com/crimson_barrel1" },
                    { 5, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4669), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4669), 4, "http://example.com/the_velvet_spoon0" },
                    { 6, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4673), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4673), 5, "http://example.com/seaside_grill0" },
                    { 7, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4674), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4674), 5, "http://example.com/seaside_grill1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_RestaurantId",
                table: "Favourites",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_UserId",
                table: "Favourites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCriterias_RestaurantId",
                table: "RestaurantCriterias",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCuisines_RestaurantId",
                table: "RestaurantCuisines",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCuisines_TypeId",
                table: "RestaurantCuisines",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantImageUrls_RestaurantId",
                table: "RestaurantImageUrls",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RestaurantId",
                table: "Reviews",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UserId",
                table: "RoleUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCriterias_UserId",
                table: "UserCriterias",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSelectedCriterias_CuisineId",
                table: "UserSelectedCriterias",
                column: "CuisineId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSelectedCriterias_UserId",
                table: "UserSelectedCriterias",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "RestaurantCriterias");

            migrationBuilder.DropTable(
                name: "RestaurantCuisines");

            migrationBuilder.DropTable(
                name: "RestaurantImageUrls");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "UserCriterias");

            migrationBuilder.DropTable(
                name: "UserSelectedCriterias");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Cuisines");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
