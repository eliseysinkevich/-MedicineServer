namespace MedicineServer.Model
{
	public class Diagnosis
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public Problem Problem { get; set; }
		public Doctor Doctor { get; set; }
	}
}
