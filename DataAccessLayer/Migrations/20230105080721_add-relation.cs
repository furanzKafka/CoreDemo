using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BlogRatings_BlogId",
                table: "BlogRatings",
                column: "BlogId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogRatings_Blogs_BlogId",
                table: "BlogRatings",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogRatings_Blogs_BlogId",
                table: "BlogRatings");

            migrationBuilder.DropIndex(
                name: "IX_BlogRatings_BlogId",
                table: "BlogRatings");
        }
    }
}
