using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployedCRUD.Migrations
{
    public partial class modificarBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Emploree",
                table: "Emploree");

            migrationBuilder.RenameTable(
                name: "Emploree",
                newName: "Employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Emploree");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emploree",
                table: "Emploree",
                column: "Id");
        }
    }
}
