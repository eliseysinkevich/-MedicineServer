namespace MedicineServer.Model
{
	public class Complaint
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public Problem Problem { get; set; }
	}
}
