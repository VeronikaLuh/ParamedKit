using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update_user_selected_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AddColumn<int>(
                name: "HighestPrice",
                table: "UserSelectedCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "UserSelectedCriterias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LowestPrice",
                table: "UserSelectedCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6384), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6385), 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6389), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6389), 6 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6398), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6398), 9 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6406), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6406), 3, 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6408), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6449), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6449), 4, 7 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6457), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6458), 5, 7 });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6210), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6213), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6214), 1, "http://example.com/the_golden_oak1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6245), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6245), 2, "http://example.com/luna’s_bistro0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6246), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6246), 2, "http://example.com/luna’s_bistro1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6249), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6249), 3, "http://example.com/crimson_barrel0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6252), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6252), 3, "http://example.com/crimson_barrel1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6255), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6255), 4, "http://example.com/the_velvet_spoon0" });

            migrationBuilder.InsertData(
                table: "RestaurantImageUrls",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[,]
                {
                    { 8, new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6260), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6261), 5, "http://example.com/seaside_grill0" },
                    { 9, new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6262), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6262), 5, "http://example.com/seaside_grill1" }
                });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6084), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6088), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6088), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6089), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6090), new DateTime(2024, 11, 27, 15, 37, 18, 458, DateTimeKind.Utc).AddTicks(6090) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "HighestPrice",
                table: "UserSelectedCriterias");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "UserSelectedCriterias");

            migrationBuilder.DropColumn(
                name: "LowestPrice",
                table: "UserSelectedCriterias");

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4814), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4815), 3 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4817), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4817), 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4827), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4828), 1 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4829), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4829), 2, 9 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4839), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4841), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4841), 3, 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4850), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4850), 4, 5 });

            migrationBuilder.InsertData(
                table: "RestaurantCuisines",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[,]
                {
                    { 8, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4858), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4858), 5, 7 },
                    { 9, new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4859), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4859), 5, 8 }
                });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4584), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4623), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4624), 2, "http://example.com/luna’s_bistro0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4627), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4627), 3, "http://example.com/crimson_barrel0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4665), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4666), 3, "http://example.com/crimson_barrel1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4669), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4669), 4, "http://example.com/the_velvet_spoon0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4673), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4673), 5, "http://example.com/seaside_grill0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4674), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4674), 5, "http://example.com/seaside_grill1" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4469), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4473), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4474), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4475), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4475), new DateTime(2024, 11, 27, 14, 43, 24, 312, DateTimeKind.Utc).AddTicks(4476) });
        }
    }
}
