using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineServer.Model
{
	public class DiseaseTreatment
	{
		public int Id { get; set; }
		public Treatment Treatment { get; set; }
		public Disease Disease { get; set; }
	}
}
