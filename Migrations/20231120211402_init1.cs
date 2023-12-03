using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITIproject.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_DEpartmentId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_DEpartmentId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "DEpartmentId",
                table: "Student");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Dept",
                table: "Student",
                column: "Dept");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_Dept",
                table: "Student",
                column: "Dept",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_Dept",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_Dept",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "DEpartmentId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Student_DEpartmentId",
                table: "Student",
                column: "DEpartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_DEpartmentId",
                table: "Student",
                column: "DEpartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
