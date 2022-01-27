using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StratDate",
                table: "Movies",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Descriptoin",
                table: "Cinemas",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Movies",
                newName: "StratDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "Descriptoin");
        }
    }
}
