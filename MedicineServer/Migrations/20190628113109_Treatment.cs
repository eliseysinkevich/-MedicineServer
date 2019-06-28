using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicineServer.Migrations
{
    public partial class Treatment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Medicaments_MedicamentId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_MedicamentId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "MedicamentId",
                table: "Prescriptions");

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    MedicamentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatments_Medicaments_MedicamentId",
                        column: x => x.MedicamentId,
                        principalTable: "Medicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseTreatments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TreatmentId = table.Column<int>(nullable: true),
                    DiseaseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseTreatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiseaseTreatments_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiseaseTreatments_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionTreatments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrescriptionId = table.Column<int>(nullable: true),
                    TreatmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionTreatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescriptionTreatments_Prescriptions_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrescriptionTreatments_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseTreatments_DiseaseId",
                table: "DiseaseTreatments",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseTreatments_TreatmentId",
                table: "DiseaseTreatments",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionTreatments_PrescriptionId",
                table: "PrescriptionTreatments",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionTreatments_TreatmentId",
                table: "PrescriptionTreatments",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_MedicamentId",
                table: "Treatments",
                column: "MedicamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseaseTreatments");

            migrationBuilder.DropTable(
                name: "PrescriptionTreatments");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.AddColumn<int>(
                name: "MedicamentId",
                table: "Prescriptions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_MedicamentId",
                table: "Prescriptions",
                column: "MedicamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Medicaments_MedicamentId",
                table: "Prescriptions",
                column: "MedicamentId",
                principalTable: "Medicaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
