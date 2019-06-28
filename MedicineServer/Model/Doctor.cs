namespace MedicineServer.Model
{
	public class Doctor : Person
	{
		public int Id { get; set; }
		public string Username { get; set; }
		private string Password { get; set; }
	}
}
