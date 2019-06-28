namespace MedicineServer.Model
{
	public class DiagnosisDisease
	{
		public int Id { get; set; }
		public Diagnosis Diagnosis { get; set; }
		public Disease Disease { get; set; }
	}
}
