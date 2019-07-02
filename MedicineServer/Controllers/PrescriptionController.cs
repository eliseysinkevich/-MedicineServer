using System.Collections.Generic;
using System.Linq;
using MedicineServer.Model;
using Microsoft.AspNetCore.Mvc;

namespace MedicineServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
	{
		private readonly MedicineContext _db;

		public PrescriptionController(MedicineContext context)
		{
			_db = context;
		}

		[HttpGet("prescription/{id}")]
		public ActionResult<Prescription> GetPrescription(int id)
		{
			Prescription prescription = _db.Prescriptions.FirstOrDefault(e => e.Id == id);

			if (prescription == null)
			{
				return NotFound();
			}

			return Ok(prescription);
		}

		[HttpGet("prescriptions")]
		public IEnumerable<Prescription> GetPrescriptions()
		{
			return _db.Prescriptions;
		}

		[HttpPost("prescription")]
		public ActionResult<Prescription> PostPrescription([FromBody] Prescription prescription)
		{
			Prescription oldPrescription = _db.Find<Prescription>(prescription.Id);

			if (oldPrescription != null)
			{
				return BadRequest();
			}

			_db.Prescriptions.Add(prescription);
			_db.SaveChanges();

			return Ok(prescription);
		}

		[HttpPut("prescription")]
		public ActionResult<Prescription> UpdatePrescription([FromBody] Prescription prescription)
		{
			if (!_db.Prescriptions.Any(e => e.Id == prescription.Id))
			{
				return NotFound();
			}

			_db.Prescriptions.Update(prescription);
			_db.SaveChanges();

			return Ok(prescription);
		}

		[HttpDelete("prescription/{id}")]
		public IActionResult DeletePrescription(int id)
		{
			Prescription prescription = _db.Find<Prescription>(id);

			if (prescription == null)
			{
				return NotFound();
			}

			_db.Prescriptions.Remove(prescription);
			_db.SaveChanges();

			return Ok();
		}

		[HttpGet("prescriptionTreatment/{id}")]
		public ActionResult<PrescriptionTreatment> GetPrescriptionTreatment(int id)
		{
			PrescriptionTreatment prescriptionTreatment = _db.PrescriptionTreatments.FirstOrDefault(e => e.Id == id);

			if (prescriptionTreatment == null)
			{
				return NotFound();
			}

			return Ok(prescriptionTreatment);
		}

		[HttpGet("prescriptionTreatments")]
		public IEnumerable<PrescriptionTreatment> GetPrescriptionTreatments()
		{
			return _db.PrescriptionTreatments;
		}

		[HttpPost("prescriptionTreatment")]
		public ActionResult<PrescriptionTreatment> PostPrescriptionTreatment([FromBody] PrescriptionTreatment prescriptionTreatment)
		{
			PrescriptionTreatment oldPrescriptionTreatment = _db.Find<PrescriptionTreatment>(prescriptionTreatment.Id);

			if (oldPrescriptionTreatment != null)
			{
				return BadRequest();
			}

			_db.PrescriptionTreatments.Add(prescriptionTreatment);
			_db.SaveChanges();

			return Ok(prescriptionTreatment);
		}

		[HttpPut("prescriptionTreatment")]
		public ActionResult<PrescriptionTreatment> UpdatePrescriptionTreatment([FromBody] PrescriptionTreatment prescriptionTreatment)
		{
			if (!_db.PrescriptionTreatments.Any(e => e.Id == prescriptionTreatment.Id))
			{
				return NotFound();
			}

			_db.PrescriptionTreatments.Update(prescriptionTreatment);
			_db.SaveChanges();

			return Ok(prescriptionTreatment);
		}

		[HttpDelete("prescriptionTreatment/{id}")]
		public IActionResult DeletePrescriptionTreatment(int id)
		{
			PrescriptionTreatment prescriptionTreatment = _db.Find<PrescriptionTreatment>(id);

			if (prescriptionTreatment == null)
			{
				return NotFound();
			}

			_db.PrescriptionTreatments.Remove(prescriptionTreatment);
			_db.SaveChanges();

			return Ok();
		}
	}
}