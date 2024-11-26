using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_Favourites_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7);

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
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 994, DateTimeKind.Utc).AddTicks(64), new DateTime(2024, 11, 26, 12, 57, 44, 994, DateTimeKind.Utc).AddTicks(64), 7 });

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
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9870), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9872), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9872), 2, "http://example.com/luna’s_bistro1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9877), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9877), 3, "http://example.com/crimson_barrel0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9882), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9882), "http://example.com/the_velvet_spoon0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9885), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9886), 4, "http://example.com/the_velvet_spoon1" });

            migrationBuilder.InsertData(
                table: "RestaurantImageUrls",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { 7, new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 11, 26, 12, 57, 44, 993, DateTimeKind.Utc).AddTicks(9890), 5, "http://example.com/seaside_grill0" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_RestaurantId",
                table: "Favourites",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_UserId",
                table: "Favourites",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7);

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
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4977), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4977), 6 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4979), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4979), 2, 1 });

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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4995), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4996), 4, 3 });

            migrationBuilder.InsertData(
                table: "RestaurantCuisines",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4998), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4998), 4, 10 },
                    { 7, new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(5005), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(5006), 5, 3 }
                });

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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4817), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4817), 3, "http://example.com/crimson_barrel0" });

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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4824), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4825), 5, "http://example.com/seaside_grill0" });

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
