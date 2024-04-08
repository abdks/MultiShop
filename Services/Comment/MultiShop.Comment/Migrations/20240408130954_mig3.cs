using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiShop.Comment.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "UserComments");

            migrationBuilder.RenameColumn(
                name: "Raiting",
                table: "UserComments",
                newName: "Rating");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserComments",
                table: "UserComments",
                column: "UserCommentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserComments",
                table: "UserComments");

            migrationBuilder.RenameTable(
                name: "UserComments",
                newName: "Comments");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Comments",
                newName: "Raiting");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "UserCommentId");
        }
    }
}
