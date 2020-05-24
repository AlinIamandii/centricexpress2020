using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Data.Migrations
{
    public partial class AddCharactersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0e4b647b-ed9b-480e-901d-c370c67289b0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3c79121f-697d-4d6d-a47f-80f695f82003"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("db0c28d5-4c33-4bff-9bbb-dfda6d7f245c"));

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    MovieId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "HasWonOscar", "Rating", "Title", "Year" },
                values: new object[] { new Guid("d8bacea7-5208-4e60-9843-c789d6d93c0e"), true, 7.7999999999999998, "Titanic", 1997 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "HasWonOscar", "Rating", "Title", "Year" },
                values: new object[] { new Guid("41f5d223-3457-43f2-b9f4-cf893f78b6c5"), false, 7.7999999999999998, "The Notebook", 2004 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "HasWonOscar", "Rating", "Title", "Year" },
                values: new object[] { new Guid("55b19edc-6722-4e06-9c4a-584c4bf9341c"), true, 6.7999999999999998, "Avatar", 2009 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("18b5831b-40e0-4ab0-9522-a0ab59c02dc1"), new Guid("d8bacea7-5208-4e60-9843-c789d6d93c0e"), "Rose" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "MovieId", "Name" },
                values: new object[] { new Guid("54e77bbd-f55f-4f52-a09c-2b47e4c41198"), new Guid("d8bacea7-5208-4e60-9843-c789d6d93c0e"), "Jack" });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_MovieId",
                table: "Characters",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("41f5d223-3457-43f2-b9f4-cf893f78b6c5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("55b19edc-6722-4e06-9c4a-584c4bf9341c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d8bacea7-5208-4e60-9843-c789d6d93c0e"));

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
    }
}
