using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_review_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 8);

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
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4987), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4987), 7 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4995), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4996), 3 });

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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4814), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4814), 2, "http://example.com/luna’s_bistro0" });

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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4821), new DateTime(2024, 11, 22, 22, 21, 34, 71, DateTimeKind.Utc).AddTicks(4821), 4, "http://example.com/the_velvet_spoon1" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RestaurantId",
                table: "Reviews",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5309), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5310), 5 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5450), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5450), 8 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5463), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5464), 3, 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5466), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5466), 5 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5478), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5478), 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5482), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5482), 1 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5494), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5494), 9 });

            migrationBuilder.InsertData(
                table: "RestaurantCuisines",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { 8, new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5496), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5496), 5, 5 });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5141), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5146), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5146), 1, "http://example.com/the_golden_oak1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5187), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5188), 2, "http://example.com/luna’s_bistro0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5191), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5192), 3, "http://example.com/crimson_barrel0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5193), 3, "http://example.com/crimson_barrel1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5199), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5200), 4, "http://example.com/the_velvet_spoon0" });

            migrationBuilder.InsertData(
                table: "RestaurantImageUrls",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[,]
                {
                    { 7, new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5201), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5201), 4, "http://example.com/the_velvet_spoon1" },
                    { 8, new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5205), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5205), 5, "http://example.com/seaside_grill0" }
                });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5010), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5015), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5016), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5017), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5018), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5018) });
        }
    }
}
