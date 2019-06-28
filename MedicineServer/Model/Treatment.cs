using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineServer.Model
{
	public class Treatment
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public Medicament Medicament { get; set; }
	}
}
