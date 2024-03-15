using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EweForum.Infrastructure.Migrations
{
    public partial class RenameDataset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forums_AspNetUsers_ForumUserId",
                table: "Forums");

            migrationBuilder.DropForeignKey(
                name: "FK_Forums_FilesAttachments_FileAttachmentId",
                table: "Forums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Forums",
                table: "Forums");

            migrationBuilder.RenameTable(
                name: "Forums",
                newName: "ForumUsersAttachments");

            migrationBuilder.RenameIndex(
                name: "IX_Forums_ForumUserId",
                table: "ForumUsersAttachments",
                newName: "IX_ForumUsersAttachments_ForumUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForumUsersAttachments",
                table: "ForumUsersAttachments",
                columns: new[] { "FileAttachmentId", "ForumUserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ForumUsersAttachments_AspNetUsers_ForumUserId",
                table: "ForumUsersAttachments",
                column: "ForumUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumUsersAttachments_FilesAttachments_FileAttachmentId",
                table: "ForumUsersAttachments",
                column: "FileAttachmentId",
                principalTable: "FilesAttachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumUsersAttachments_AspNetUsers_ForumUserId",
                table: "ForumUsersAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumUsersAttachments_FilesAttachments_FileAttachmentId",
                table: "ForumUsersAttachments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForumUsersAttachments",
                table: "ForumUsersAttachments");

            migrationBuilder.RenameTable(
                name: "ForumUsersAttachments",
                newName: "Forums");

            migrationBuilder.RenameIndex(
                name: "IX_ForumUsersAttachments_ForumUserId",
                table: "Forums",
                newName: "IX_Forums_ForumUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forums",
                table: "Forums",
                columns: new[] { "FileAttachmentId", "ForumUserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_AspNetUsers_ForumUserId",
                table: "Forums",
                column: "ForumUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_FilesAttachments_FileAttachmentId",
                table: "Forums",
                column: "FileAttachmentId",
                principalTable: "FilesAttachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
