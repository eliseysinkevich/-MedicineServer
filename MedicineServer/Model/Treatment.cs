namespace MedicineServer.Model
{
	public class Treatment
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public Medicament Medicament { get; set; }
	}
}
