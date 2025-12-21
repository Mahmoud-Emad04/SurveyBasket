using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SurveyBasket.Api.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "IsDefault", "IsDeleted", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "019ab5a3-19f8-7c9f-a8e2-33e8020eb219", "019ab5a3-19f8-7c9f-a8e2-33e968a14dce", false, false, "Admin", "ADMIN" },
                    { "019ab5a3-19f8-7c9f-a8e2-33ea0996f8ce", "019ab5a3-19f8-7c9f-a8e2-33eb6ebb9264", true, false, "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "019ab5a3-19f8-7c9f-a8e2-33e5bafc9655", 0, "019ab5a3-19f8-7c9f-a8e2-33e6b5b96b85", "admin@survey-basket.com", true, "Survey Basket", "Admin", false, null, "ADMIN@SURVEY-BASKET.COM", "ADMIN@SURVEY-BASKET.COM", "AQAAAAIAAYagAAAAEJGFhcPnImW2qFZyvSnFYQisMzpQl7bl2FEhWwgOpROln/769+DaaW+lTqt5p5o4xw==", null, false, "019ab5a319f87c9fa8e233e78f683f26", false, "admin@survey-basket.com" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "permissions", "polls:read", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 2, "permissions", "polls:add", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 3, "permissions", "polls:update", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 4, "permissions", "polls:delete", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 5, "permissions", "questions:read", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 6, "permissions", "questions:add", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 7, "permissions", "questions:update", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 8, "permissions", "users:read", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 9, "permissions", "users:add", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 10, "permissions", "users:update", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 11, "permissions", "roles:read", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 12, "permissions", "roles:add", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 13, "permissions", "roles:update", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" },
                    { 14, "permissions", "results:read", "019ab5a3-19f8-7c9f-a8e2-33e8020eb219" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "019ab5a3-19f8-7c9f-a8e2-33e8020eb219", "019ab5a3-19f8-7c9f-a8e2-33e5bafc9655" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "019ab5a3-19f8-7c9f-a8e2-33ea0996f8ce");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "019ab5a3-19f8-7c9f-a8e2-33e8020eb219", "019ab5a3-19f8-7c9f-a8e2-33e5bafc9655" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "019ab5a3-19f8-7c9f-a8e2-33e8020eb219");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "019ab5a3-19f8-7c9f-a8e2-33e5bafc9655");
        }
    }
}
