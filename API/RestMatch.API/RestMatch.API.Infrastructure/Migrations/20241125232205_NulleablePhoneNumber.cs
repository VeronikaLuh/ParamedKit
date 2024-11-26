using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NulleablePhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3603), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3605), 9 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3612), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3612), 3 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3634), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3635), 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3653), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3653), 3, 7 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3655), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3655), 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3679), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3679), 7 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3681), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3681), 4, 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3699), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3700), 7 });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2766), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2914), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2921), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2924), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2930), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2937), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2938), 4, "http://example.com/the_velvet_spoon1" });

            migrationBuilder.InsertData(
                table: "RestaurantImageUrls",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[,]
                {
                    { 7, new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2946), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2946), 5, "http://example.com/seaside_grill0" },
                    { 8, new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2948), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2948), 5, "http://example.com/seaside_grill1" }
                });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2307), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2317), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2319), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2320), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2321), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2321) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
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
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5985), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5985), 4 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5988), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5989), 9 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6001), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6001), 2 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6004), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6004), 2, 5 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6015), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6015), 3 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6027), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6027), 5 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6037), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6038), 5, 2 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6040), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6040), 4 });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5772), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5817), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5875), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5877), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5884), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5889), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5889), 5, "http://example.com/seaside_grill0" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5629), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5637), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5638), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5638), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5639), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5639) });
        }
    }
}
