namespace MedicineServer.Model
{
	public class Diagnosis
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public Examination Examination { get; set; }
		public Doctor Doctor { get; set; }
	}
}
