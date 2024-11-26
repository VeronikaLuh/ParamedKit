using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5988), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5989), 1, 9 });

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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId" },
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
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6037), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6038), 2 });

            migrationBuilder.InsertData(
                table: "RestaurantCuisines",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { 8, new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6040), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(6040), 5, 4 });

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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5877), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5877), 3, "http://example.com/crimson_barrel1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5884), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5884), "http://example.com/the_velvet_spoon0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5889), new DateTime(2024, 11, 25, 23, 8, 52, 395, DateTimeKind.Utc).AddTicks(5889) });

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RoleName", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, "User", null },
                    { 2, null, null, "Moderator", null },
                    { 3, null, null, "Admin", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4960), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4961), 1 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4977), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4977), 2, 6 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4979), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4979), 1 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4987), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4987), 3, 7 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4995), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4996), 4 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4998), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4998), 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(5005), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(5006), 3 });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4775), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4814), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4817), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4819), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4819), 4, "http://example.com/the_velvet_spoon0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4821), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4821), "http://example.com/the_velvet_spoon1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4824), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4650), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4656), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4656), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4657), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4658), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4658) });
        }
    }
}
