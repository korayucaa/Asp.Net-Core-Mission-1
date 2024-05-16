using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryDescrption",
                table: "Categories",
                newName: "CategoryDescription");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CategoryID",
                table: "Comments",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Categories_CategoryID",
                table: "Comments",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Categories_CategoryID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CategoryID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CategoryDescription",
                table: "Categories",
                newName: "CategoryDescrption");
        }
    }
}
