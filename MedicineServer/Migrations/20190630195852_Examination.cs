using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicineServer.Migrations
{
    public partial class Examination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaints_Problems_ProblemId",
                table: "Complaints");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_Problems_ProblemId",
                table: "Diagnoses");

            migrationBuilder.DropTable(
                name: "Problems");

            migrationBuilder.RenameColumn(
                name: "ProblemId",
                table: "Diagnoses",
                newName: "ExaminationId");

            migrationBuilder.RenameIndex(
                name: "IX_Diagnoses_ProblemId",
                table: "Diagnoses",
                newName: "IX_Diagnoses_ExaminationId");

            migrationBuilder.RenameColumn(
                name: "ProblemId",
                table: "Complaints",
                newName: "ExaminationId");

            migrationBuilder.RenameIndex(
                name: "IX_Complaints_ProblemId",
                table: "Complaints",
                newName: "IX_Complaints_ExaminationId");

            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    ProblemDate = table.Column<DateTime>(nullable: false),
                    PatientId = table.Column<int>(nullable: true),
                    DoctorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examinations_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examinations_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_DoctorId",
                table: "Examinations",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_PatientId",
                table: "Examinations",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaints_Examinations_ExaminationId",
                table: "Complaints",
                column: "ExaminationId",
                principalTable: "Examinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_Examinations_ExaminationId",
                table: "Diagnoses",
                column: "ExaminationId",
                principalTable: "Examinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaints_Examinations_ExaminationId",
                table: "Complaints");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_Examinations_ExaminationId",
                table: "Diagnoses");

            migrationBuilder.DropTable(
                name: "Examinations");

            migrationBuilder.RenameColumn(
                name: "ExaminationId",
                table: "Diagnoses",
                newName: "ProblemId");

            migrationBuilder.RenameIndex(
                name: "IX_Diagnoses_ExaminationId",
                table: "Diagnoses",
                newName: "IX_Diagnoses_ProblemId");

            migrationBuilder.RenameColumn(
                name: "ExaminationId",
                table: "Complaints",
                newName: "ProblemId");

            migrationBuilder.RenameIndex(
                name: "IX_Complaints_ExaminationId",
                table: "Complaints",
                newName: "IX_Complaints_ProblemId");

            migrationBuilder.CreateTable(
                name: "Problems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    DoctorId = table.Column<int>(nullable: true),
                    PatientId = table.Column<int>(nullable: true),
                    ProblemDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Problems_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Problems_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Problems_DoctorId",
                table: "Problems",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Problems_PatientId",
                table: "Problems",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaints_Problems_ProblemId",
                table: "Complaints",
                column: "ProblemId",
                principalTable: "Problems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_Problems_ProblemId",
                table: "Diagnoses",
                column: "ProblemId",
                principalTable: "Problems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
