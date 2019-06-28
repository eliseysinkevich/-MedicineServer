namespace MedicineServer.Model
{
	public class Doctor : Person
	{
		public string Username { get; set; }
		private string Password { get; set; }
	}
}
