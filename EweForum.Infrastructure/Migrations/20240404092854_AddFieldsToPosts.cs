using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EweForum.Infrastructure.Migrations
{
    public partial class AddFieldsToPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Posts",
                newName: "VideoDescription");

            migrationBuilder.AddColumn<string>(
                name: "EventDescription",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropColumn(
                name: "EventDescription",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "VideoDescription",
                table: "Posts",
                newName: "Description");
        }

    }
}
