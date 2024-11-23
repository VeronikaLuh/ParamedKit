using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_Count_Fields_to_some_entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateAmerican",
                table: "UserCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateChinese",
                table: "UserCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateFrench",
                table: "UserCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateGreek",
                table: "UserCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateIndian",
                table: "UserCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateItalian",
                table: "UserCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateJapanese",
                table: "UserCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateMediterranean",
                table: "UserCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateMexican",
                table: "UserCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateUkrainian",
                table: "UserCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRate",
                table: "Restaurants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateAmerican",
                table: "RestaurantCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateChinese",
                table: "RestaurantCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateFrench",
                table: "RestaurantCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateGreek",
                table: "RestaurantCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateIndian",
                table: "RestaurantCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateItalian",
                table: "RestaurantCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateJapanese",
                table: "RestaurantCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateMediterranean",
                table: "RestaurantCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateMexican",
                table: "RestaurantCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountOfRateUkrainian",
                table: "RestaurantCriterias",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5450), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5450), 2, 8 });

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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5482), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5482), 4, 1 });

            migrationBuilder.InsertData(
                table: "RestaurantCuisines",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[,]
                {
                    { 7, new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5494), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5494), 5, 9 },
                    { 8, new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5496), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5496), 5, 5 }
                });

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
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5187), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5188), "http://example.com/luna’s_bistro0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5191), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5199), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5201), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5205), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CountOfRate", "CreatedAt", "ModifiedAt" },
                values: new object[] { 0, new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5010), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountOfRate", "CreatedAt", "ModifiedAt" },
                values: new object[] { 0, new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5015), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountOfRate", "CreatedAt", "ModifiedAt" },
                values: new object[] { 0, new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5016), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountOfRate", "CreatedAt", "ModifiedAt" },
                values: new object[] { 0, new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5017), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountOfRate", "CreatedAt", "ModifiedAt" },
                values: new object[] { 0, new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5018), new DateTime(2024, 11, 22, 22, 2, 27, 862, DateTimeKind.Utc).AddTicks(5018) });
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

            migrationBuilder.DropColumn(
                name: "CountOfRateAmerican",
                table: "UserCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateChinese",
                table: "UserCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateFrench",
                table: "UserCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateGreek",
                table: "UserCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateIndian",
                table: "UserCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateItalian",
                table: "UserCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateJapanese",
                table: "UserCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateMediterranean",
                table: "UserCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateMexican",
                table: "UserCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateUkrainian",
                table: "UserCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRate",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "CountOfRateAmerican",
                table: "RestaurantCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateChinese",
                table: "RestaurantCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateFrench",
                table: "RestaurantCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateGreek",
                table: "RestaurantCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateIndian",
                table: "RestaurantCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateItalian",
                table: "RestaurantCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateJapanese",
                table: "RestaurantCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateMediterranean",
                table: "RestaurantCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateMexican",
                table: "RestaurantCriterias");

            migrationBuilder.DropColumn(
                name: "CountOfRateUkrainian",
                table: "RestaurantCriterias");

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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1611), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1611), 2, 9 });

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
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1629), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1629), 8 });

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
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1475), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1476), new DateTime(2024, 11, 21, 21, 34, 57, 609, DateTimeKind.Utc).AddTicks(1476) });

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
        }
    }
}
