using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerBlazorEF.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "c2c44821-a17b-44fa-9684-d77034abbe01", "Jane", "Smith", "Medicine" },
                    { "647cb82b-53cc-438d-a58d-d73412df1d13", "John", "Fisher", "Engineering" },
                    { "a3172925-28a0-4718-b176-e021016b4ca5", "Pamela", "Baker", "Food Science" },
                    { "63f73a0e-b419-4772-992d-520c28f23f98", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
