using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class nullableUserImageUrlField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6900), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6926), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6927), 1 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6929), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6930), 2, 9 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6948), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6948), 3, 1 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6951), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6952), 3, 2 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6972), 4 });

            migrationBuilder.InsertData(
                table: "RestaurantCuisines",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[,]
                {
                    { 7, new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6974), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6975), 4, 7 },
                    { 8, new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6993), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6994), 5, 3 },
                    { 9, new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6996), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6997), 5, 5 }
                });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6397), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6405), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6405), 1, "http://example.com/the_golden_oak1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6468), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6469), 2, "http://example.com/luna’s_bistro0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6475), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6476), "http://example.com/crimson_barrel0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6478), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6478), 3, "http://example.com/crimson_barrel1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6486), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6487), "http://example.com/the_velvet_spoon0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6491), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(5937), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(5942), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(5943), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(5945), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(5946), new DateTime(2024, 11, 27, 22, 11, 24, 846, DateTimeKind.Utc).AddTicks(5946) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(249), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(269), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(270), 5 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(285), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(286), 3, 2 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(300), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(300), 4, 9 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(313), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(313), 5, 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(351), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(351), 5 });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9949), new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(1), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(2), 2, "http://example.com/luna’s_bistro0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(7), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(8), 3, "http://example.com/crimson_barrel0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(13), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(13), "http://example.com/crimson_barrel1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(17), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(18), 4, "http://example.com/the_velvet_spoon0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(22), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(22), "http://example.com/the_velvet_spoon1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(25), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.InsertData(
                table: "RestaurantImageUrls",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { 8, new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(27), new DateTime(2024, 11, 27, 22, 6, 55, 769, DateTimeKind.Utc).AddTicks(28), 5, "http://example.com/seaside_grill1" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9635), new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9642), new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9643), new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9643), new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9644), new DateTime(2024, 11, 27, 22, 6, 55, 768, DateTimeKind.Utc).AddTicks(9645) });
        }
    }
}
