using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestMatch.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addUserRoleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_UserId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_UserId",
                table: "Roles");

            migrationBuilder.DeleteData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "UserRoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Roles");

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UserId",
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
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1065), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1066), 10 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1068), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1069), 8 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1080), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1080), 9 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1089), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1090), 1 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1100), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1100), 4, 3 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1102), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1103), 6 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1137), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1138), 5, 8 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1139), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(689), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(761), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(765), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(766), 2, "http://example.com/luna’s_bistro1" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(770), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(771), "http://example.com/crimson_barrel0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(773), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(776), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(778), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(447), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(457), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(458), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(458), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(459), new DateTime(2024, 11, 26, 23, 7, 22, 127, DateTimeKind.Utc).AddTicks(459) });

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UserId",
                table: "RoleUser",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.AddColumn<int>(
                name: "UserRoleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Roles",
                type: "int",
                nullable: true);

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
                columns: new[] { "CreatedAt", "ModifiedAt", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3653), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3653), 7 });

            migrationBuilder.UpdateData(
                table: "RestaurantCuisines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "TypeId" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3655), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3655), 3, 10 });

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
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3699), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(3700) });

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
                columns: new[] { "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2921), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2922), 3, "http://example.com/crimson_barrel0" });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "Url" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2924), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2924), "http://example.com/crimson_barrel1" });

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
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2937), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "RestaurantImageUrls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2946), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.InsertData(
                table: "RestaurantImageUrls",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "RestaurantId", "Url" },
                values: new object[] { 8, new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2948), new DateTime(2024, 11, 25, 23, 22, 4, 577, DateTimeKind.Utc).AddTicks(2948), 5, "http://example.com/seaside_grill1" });

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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserId",
                table: "Roles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_UserId",
                table: "Roles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
