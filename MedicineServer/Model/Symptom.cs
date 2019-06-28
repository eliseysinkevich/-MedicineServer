namespace MedicineServer.Model
{
	public class Symptom
	{
		public int Id { get; set; }
		public Archetype Archetype { get; set; }
		public string ArchetypeValue { get; set; }
		public DiagnosisDisease DiagnosisDisease { get; set; }
	}
}
