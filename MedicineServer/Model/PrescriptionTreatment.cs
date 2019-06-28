namespace MedicineServer.Model
{
	public class PrescriptionTreatment
	{
		public int Id { get; set; }
		public  Prescription Prescription { get; set; }
		public Treatment Treatment { get; set; }
	}
}