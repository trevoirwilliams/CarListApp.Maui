using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Make = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Vin = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[] { 1, "Honda", "Fit", "ABC" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[] { 2, "Honda", "Civic", "ABC2" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[] { 3, "Honda", "Stream", "ABC1" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[] { 4, "Nissan", "Note", "ABC4" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[] { 5, "Nissan", "Atlas", "ABC5" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[] { 6, "Nissan", "Dualis", "ABC6" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[] { 7, "Nissan", "Murano", "ABC7" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[] { 8, "Audi", "A5", "ABC8" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[] { 9, "BMW", "M3", "ABC9" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model", "Vin" },
                values: new object[] { 10, "Jaguar", "F-Pace", "ABC10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
