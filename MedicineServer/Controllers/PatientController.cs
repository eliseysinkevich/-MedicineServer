using System.Collections.Generic;
using System.Linq;
using MedicineServer.Model;
using Microsoft.AspNetCore.Mvc;

namespace MedicineServer.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class PatientController : ControllerBase
	{
		private readonly MedicineContext _db;

		public PatientController(MedicineContext context)
		{
			_db = context;
		}

		[HttpGet("patient/{id}")]
		public ActionResult<Patient> GetPatient(int id)
		{
			Patient patient = _db.Patients.FirstOrDefault(p => p.Id == id);

			if (patient == null)
			{
				return NotFound();
			}

			return Ok(patient);
		}

		[HttpGet("patients")]
		public IEnumerable<Patient> GetPatients()
		{
			return _db.Patients;
		}

		[HttpPost("patient")]
		public ActionResult<Patient> PostPatient([FromBody] Patient patient)
		{
			Patient oldPatient = _db.Find<Patient>(patient.Id);

			if (oldPatient != null)
			{
				return BadRequest();
			}

			_db.Patients.Add(patient);
			_db.SaveChanges();

			return Ok(patient);
		}

		[HttpPut("patient")]
		public ActionResult<Patient> UpdatePatient([FromBody] Patient patient)
		{
			if(!_db.Patients.Any(p => p.Id == patient.Id))
			{
				return NotFound();
			}

			_db.Patients.Update(patient);
			_db.SaveChanges();

			return Ok(patient);
		}

		[HttpDelete("patient/{id}")]
		public IActionResult DeletePatient(int id)
		{
			Patient patient = _db.Find<Patient>(id);

			if (patient == null)
			{
				return NotFound();
			}

			_db.Patients.Remove(patient);
			_db.SaveChanges();

			return Ok();
		}
	}
}