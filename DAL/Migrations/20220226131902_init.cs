using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountOfPurchase = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Text",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfSales = table.Column<double>(type: "float", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Text", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Text_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "CreatedDate", "Name", "NickName" },
                values: new object[] { 1, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oleg", "OLL" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "CreatedDate", "Name", "NickName" },
                values: new object[] { 2, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roman", "R0maNga" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "CreatedDate", "Name", "NickName" },
                values: new object[] { 3, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kate", "K1" });

            migrationBuilder.InsertData(
                table: "Photo",
                columns: new[] { "Id", "AmountOfPurchase", "AuthorId", "DateCreate", "Name", "PhotoLink", "Price", "Size" },
                values: new object[,]
                {
                    { 1, 10.0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat", "https://upload.wikimedia.org/wikipedia/commons/0/0e/Felis_silvestris_silvestris.jpg", 10m, 0.10000000000000001 },
                    { 2, 20.0, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.bbc.com%2Frussian%2Ffeatures-42026094&psig=AOvVaw0nDdk7YuHg0Ng35KcDlqjd&ust=1645888835929000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCPD9pO2Tm_YCFQAAAAAdAAAAABAD", 5m, 0.20000000000000001 },
                    { 3, 30.0, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fish", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTr5mkpGpBy9xQgR2soK52FINmgWr7A5x9oEw&usqp=CAU", 50m, 0.29999999999999999 }
                });

            migrationBuilder.InsertData(
                table: "Text",
                columns: new[] { "Id", "AuthorId", "Content", "DateOfCreate", "Name", "NumberOfSales", "Price", "Size" },
                values: new object[,]
                {
                    { 1, 1, "smth adout books", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "About books", 10.0, 4m, 0.10000000000000001 },
                    { 2, 2, "smth adout animals", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "About animals", 20.0, 8m, 1.0 },
                    { 3, 3, "nothing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "About nothing", 1.0, 1m, 0.20000000000000001 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_AuthorId",
                table: "Photo",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Text_AuthorId",
                table: "Text",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Text");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
