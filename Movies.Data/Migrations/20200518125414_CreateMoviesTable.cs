using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Data.Migrations
{
    public partial class CreateMoviesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Rating = table.Column<double>(nullable: false),
                    HasWonOscar = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "HasWonOscar", "Rating", "Title", "Year" },
                values: new object[] { new Guid("0e4b647b-ed9b-480e-901d-c370c67289b0"), true, 7.7999999999999998, "Titanic", 1997 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "HasWonOscar", "Rating", "Title", "Year" },
                values: new object[] { new Guid("db0c28d5-4c33-4bff-9bbb-dfda6d7f245c"), false, 7.7999999999999998, "The Notebook", 2004 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "HasWonOscar", "Rating", "Title", "Year" },
                values: new object[] { new Guid("3c79121f-697d-4d6d-a47f-80f695f82003"), true, 6.7999999999999998, "Avatar", 2009 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
