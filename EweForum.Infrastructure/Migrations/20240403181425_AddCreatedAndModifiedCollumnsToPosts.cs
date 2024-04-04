using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EweForum.Infrastructure.Migrations
{
    public partial class AddCreatedAndModifiedCollumnsToPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Posts");

        }
    }
}
