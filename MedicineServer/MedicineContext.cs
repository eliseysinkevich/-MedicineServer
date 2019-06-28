using MedicineServer.Model;
using Microsoft.EntityFrameworkCore;

namespace MedicineServer
{
	public class MedicineContext : DbContext
	{
		public DbSet<Archetype> Archetypes { get; set; }
		public DbSet<Complaint> Complaints { get; set; }
		public DbSet<Diagnosis> Diagnoses { get; set; }
		public DbSet<DiagnosisDisease> DiagnosisDiseases { get; set; }
		public DbSet<Disease> Diseases { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Medicament> Medicaments { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DbSet<Prescription> Prescriptions { get; set; }
		public DbSet<Problem> Problems { get; set; }
		public DbSet<Symptom> Symptoms { get; set; }

		public MedicineContext(DbContextOptions<MedicineContext> options) : base(options)
		{
		}
	}
}
