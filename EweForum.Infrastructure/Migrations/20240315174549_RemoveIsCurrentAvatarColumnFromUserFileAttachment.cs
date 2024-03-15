using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EweForum.Infrastructure.Migrations
{
    public partial class RemoveIsCurrentAvatarColumnFromUserFileAttachment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCurrentAvatar",
                table: "ForumUsersAttachments"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
