using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_User_Selected_Criterias_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 8);

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

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1597), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1598), 2 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1601), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1602), 1, 6 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1611), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1621), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1621), 8 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1629), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1629), 4, 8 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1637), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1637), 5, 6 });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1346), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1469), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1469), 2, "http://example.com/luna’s_bistro0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1471), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1471), "http://example.com/luna’s_bistro1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1475), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1475), 3, "http://example.com/crimson_barrel0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1476), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1476), "http://example.com/crimson_barrel1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1493), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1494), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1501), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.InsertData(
                table: "RestaurantImageUrls",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { 9, new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1502), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1502), 5, "http://example.com/seaside_grill1" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1221), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1226), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1226), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1227), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1227) });

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
                name: "UserSelectedCriterias");

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8995), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8995), 6 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9006), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9006), 2, 3 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9007), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9015), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9015), 9 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9016), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9017), 3, 5 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9025), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9025), 4, 9 });

            migrationBuilder.InsertData(
                table: "RestaurantCuisines",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[,]
                {
                    { 7, new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9027), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9027), 4, 6 },
                    { 8, new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9034), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(9035), 5, 1 }
                });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8831), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8836), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8836), 1, "http://example.com/the_golden_oak1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8870), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8870), "http://example.com/luna’s_bistro0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8902), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8903), 2, "http://example.com/luna’s_bistro1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8906), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8906), "http://example.com/crimson_barrel0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8911), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8912), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8914), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8723), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8729), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8730), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8730), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8731), new DateTime(2024, 11, 21, 20, 58, 51, 734, DateTimeKind.Utc).AddTicks(8731) });
        }
    }
}
