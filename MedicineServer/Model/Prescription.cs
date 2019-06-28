namespace MedicineServer.Model
{
	public class Prescription
	{
		public int Id { get; set; }
		public Medicament Medicament { get; set; }
		public Diagnosis Diagnosis { get; set; }
	}
}
