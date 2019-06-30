using System;

namespace MedicineServer.Model
{
	public class Examination
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public DateTime ProblemDate { get; set; }
		public Patient Patient { get; set; }
		public Doctor Doctor { get; set; }
	}
}
