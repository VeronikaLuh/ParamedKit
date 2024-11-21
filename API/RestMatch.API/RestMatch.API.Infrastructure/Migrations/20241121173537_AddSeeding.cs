using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "AboutText", "Address", "City", "ClosingTime", "Country", "CreatedAt", "LowerPrice", "MenuUrl", "ModifiedAt", "Name", "OpeningTime", "PhoneNumber", "Rating", "UpperPrice" },
                values: new object[,]
                {
                    { 1, "A cozy restaurant in the heart of the forest, offering seasonal dishes.", "123 Forest Lane, Oakland", "Oakland", new TimeSpan(0, 22, 0, 0, 0), "Fictivia", new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(531), 20, "https://www.goldenoak.com/menu", new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(533), "The Golden Oak", new TimeSpan(0, 10, 0, 0, 0), "+1 234-567-8901", 4.2999999999999998, 50 },
                    { 2, "Serving fusion dishes with a magical twist.", "45 Crescent Drive, Moonlight", "Moonlight", new TimeSpan(0, 23, 0, 0, 0), "Etherea", new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(533), 30, "https://www.lunabistro.com/menu", new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(533), "Luna’s Bistro", new TimeSpan(0, 11, 0, 0, 0), "+2 345-678-9012", 4.7000000000000002, 75 },
                    { 3, "A steakhouse specializing in rare cuts and wines.", "89 Ironwood Avenue, Redstone", "Redstone", new TimeSpan(0, 23, 30, 0, 0), "Fictivia", new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(534), 50, "https://www.crimsonbarrel.com/menu", new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(534), "Crimson Barrel", new TimeSpan(0, 12, 0, 0, 0), "+3 567-890-1234", 4.5, 150 },
                    { 4, "Upscale dining with an elegant atmosphere.", "25 Sparkling Rd, Glimmerstone", "Glimmerstone", new TimeSpan(0, 20, 0, 0, 0), "Arcadia", new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(534), 40, "https://www.velvetspoon.com/menu", new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(535), "The Velvet Spoon", new TimeSpan(0, 8, 30, 0, 0), "+4 678-901-2345", 4.2000000000000002, 80 },
                    { 5, "Fresh seafood and grill dishes with an ocean view.", "101 Beachfront Blvd, Oceanview", "Oceanview", new TimeSpan(0, 21, 30, 0, 0), "Nautica", new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(535), 25, "https://www.seasidegrill.com/menu", new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(535), "Seaside Grill", new TimeSpan(0, 9, 0, 0, 0), "+5 890-123-4567", 4.5999999999999996, 60 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantCuisines",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(828), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(828), 1, 2 },
                    { 2, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(830), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(831), 1, 7 },
                    { 3, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(841), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(841), 2, 5 },
                    { 4, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(849), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(849), 3, 3 },
                    { 5, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(858), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(858), 4, 5 },
                    { 6, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(860), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(861), 4, 3 },
                    { 7, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(868), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(868), 5, 10 },
                    { 8, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(869), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(870), 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantImageUrls",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(631), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(632), 1, "http://example.com/the_golden_oak0" },
                    { 2, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(664), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(664), 2, "http://example.com/luna’s_bistro0" },
                    { 3, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(665), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(666), 2, "http://example.com/luna’s_bistro1" },
                    { 4, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(668), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(669), 3, "http://example.com/crimson_barrel0" },
                    { 5, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(671), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(671), 4, "http://example.com/the_velvet_spoon0" },
                    { 6, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(674), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(675), 5, "http://example.com/seaside_grill0" },
                    { 7, new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(675), new DateTime(2024, 11, 21, 17, 35, 37, 88, DateTimeKind.Utc).AddTicks(675), 5, "http://example.com/seaside_grill1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
