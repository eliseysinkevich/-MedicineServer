namespace MedicineServer.Model
{
	public class Complaint
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public Examination Examination { get; set; }
	}
}
