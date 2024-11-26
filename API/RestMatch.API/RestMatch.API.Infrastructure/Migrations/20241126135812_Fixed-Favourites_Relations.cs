using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixedFavourites_Relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1484), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1485), 9 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1488), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1488), 1, 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1537), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1537), 2, 3 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1545), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1546), 3, 3 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1553), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1553), 4, 2 });

            migrationBuilder.InsertData(
                table: "RestaurantCuisines",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1555), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1556), 4, 10 },
                    { 7, new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1564), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1564), 5, 2 }
                });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1369), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1372), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1372), 1, "http://example.com/the_golden_oak1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1405), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1405), "http://example.com/luna’s_bistro0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1407), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1412), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1414), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1274), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1278), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1279), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1280), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1280), new DateTime(2024, 11, 26, 13, 58, 11, 813, DateTimeKind.Utc).AddTicks(1281) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9993), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9994), 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 994, DateTimeKind.Utc).AddTicks(64), new DateTime(2024, 11, 26, 12, 57, 44, 994, DateTimeKind.Utc).AddTicks(64), 2, 7 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 994, DateTimeKind.Utc).AddTicks(73), new DateTime(2024, 11, 26, 12, 57, 44, 994, DateTimeKind.Utc).AddTicks(73), 3, 4 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 994, DateTimeKind.Utc).AddTicks(81), new DateTime(2024, 11, 26, 12, 57, 44, 994, DateTimeKind.Utc).AddTicks(81), 4, 4 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 994, DateTimeKind.Utc).AddTicks(89), new DateTime(2024, 11, 26, 12, 57, 44, 994, DateTimeKind.Utc).AddTicks(89), 5, 1 });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9829), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9870), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9870), 2, "http://example.com/luna’s_bistro0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9872), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9872), "http://example.com/luna’s_bistro1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9877), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9882), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9885), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9722), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9728), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9729), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9729), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9730), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9730) });
        }
    }
}
