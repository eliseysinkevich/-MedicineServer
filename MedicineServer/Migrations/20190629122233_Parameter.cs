using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicineServer.Migrations
{
    public partial class Parameter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Symptoms_Archetypes_ArchetypeId",
                table: "Symptoms");

            migrationBuilder.DropTable(
                name: "Archetypes");

            migrationBuilder.RenameColumn(
                name: "ArchetypeId",
                table: "Symptoms",
                newName: "ParameterId");

            migrationBuilder.RenameIndex(
                name: "IX_Symptoms_ArchetypeId",
                table: "Symptoms",
                newName: "IX_Symptoms_ParameterId");

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Symptoms_Parameters_ParameterId",
                table: "Symptoms",
                column: "ParameterId",
                principalTable: "Parameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Symptoms_Parameters_ParameterId",
                table: "Symptoms");

            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.RenameColumn(
                name: "ParameterId",
                table: "Symptoms",
                newName: "ArchetypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Symptoms_ParameterId",
                table: "Symptoms",
                newName: "IX_Symptoms_ArchetypeId");

            migrationBuilder.CreateTable(
                name: "Archetypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archetypes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Symptoms_Archetypes_ArchetypeId",
                table: "Symptoms",
                column: "ArchetypeId",
                principalTable: "Archetypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
