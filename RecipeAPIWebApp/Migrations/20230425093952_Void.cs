using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeAPIWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Void : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Users (Name) Values ('Den')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE Users WHERE Name = 'Den'");
        }
    }
}
