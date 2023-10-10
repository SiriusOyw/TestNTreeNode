using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestNTreeNode.Migrations
{
    /// <inheritdoc />
    public partial class AddSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[] { new Guid("dc13a8d8-47b7-4659-bc65-650f13e645e8"), "Root", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Sex", "UserName" },
                values: new object[] { new Guid("1db22d70-7227-43d1-aa6b-2946ff143279"), "123456", 1, 3, "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trees",
                keyColumn: "Id",
                keyValue: new Guid("dc13a8d8-47b7-4659-bc65-650f13e645e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1db22d70-7227-43d1-aa6b-2946ff143279"));
        }
    }
}
