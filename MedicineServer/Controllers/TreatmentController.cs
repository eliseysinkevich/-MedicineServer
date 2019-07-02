using System.Collections.Generic;
using System.Linq;
using MedicineServer.Model;
using Microsoft.AspNetCore.Mvc;

namespace MedicineServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TreatmentController : ControllerBase
	{
		private readonly MedicineContext _db;

		public TreatmentController(MedicineContext context)
		{
			_db = context;
		}

		[HttpGet("treatment/{id}")]
	    public ActionResult<Treatment> GetTreatment(int id)
	    {
		    Treatment treatment = _db.Treatments.FirstOrDefault(e => e.Id == id);

		    if (treatment == null)
		    {
			    return NotFound();
		    }

		    return Ok(treatment);
	    }

	    [HttpGet("treatments")]
	    public IEnumerable<Treatment> GetTreatments()
	    {
		    return _db.Treatments;
	    }

	    [HttpPost("treatment")]
	    public ActionResult<Treatment> PostTreatment([FromBody] Treatment treatment)
	    {
		    Treatment oldTreatment = _db.Find<Treatment>(treatment.Id);

		    if (oldTreatment != null)
		    {
			    return BadRequest();
		    }

		    _db.Treatments.Add(treatment);
		    _db.SaveChanges();

		    return Ok(treatment);
	    }

	    [HttpPut("treatment")]
	    public ActionResult<Treatment> UpdateTreatment([FromBody] Treatment treatment)
	    {
		    if (!_db.Treatments.Any(e => e.Id == treatment.Id))
		    {
			    return NotFound();
		    }

		    _db.Treatments.Update(treatment);
		    _db.SaveChanges();

		    return Ok(treatment);
	    }

	    [HttpDelete("treatment/{id}")]
	    public IActionResult DeleteTreatment(int id)
	    {
		    Treatment treatment = _db.Find<Treatment>(id);

		    if (treatment == null)
		    {
			    return NotFound();
		    }

		    _db.Treatments.Remove(treatment);
		    _db.SaveChanges();

		    return Ok();
	    }

	    [HttpGet("diseaseTreatment/{id}")]
	    public ActionResult<DiseaseTreatment> GetDiseaseTreatment(int id)
	    {
		    DiseaseTreatment diseaseTreatment = _db.DiseaseTreatments.FirstOrDefault(e => e.Id == id);

		    if (diseaseTreatment == null)
		    {
			    return NotFound();
		    }

		    return Ok(diseaseTreatment);
	    }

	    [HttpGet("diseaseTreatments")]
	    public IEnumerable<DiseaseTreatment> GetDiseaseTreatments()
	    {
		    return _db.DiseaseTreatments;
	    }

	    [HttpPost("diseaseTreatment")]
	    public ActionResult<DiseaseTreatment> PostDiseaseTreatment([FromBody] DiseaseTreatment diseaseTreatment)
	    {
		    DiseaseTreatment oldDiseaseTreatment = _db.Find<DiseaseTreatment>(diseaseTreatment.Id);

		    if (oldDiseaseTreatment != null)
		    {
			    return BadRequest();
		    }

		    _db.DiseaseTreatments.Add(diseaseTreatment);
		    _db.SaveChanges();

		    return Ok(diseaseTreatment);
	    }

	    [HttpPut("diseaseTreatment")]
	    public ActionResult<DiseaseTreatment> UpdateDiseaseTreatment([FromBody] DiseaseTreatment diseaseTreatment)
	    {
		    if (!_db.DiseaseTreatments.Any(e => e.Id == diseaseTreatment.Id))
		    {
			    return NotFound();
		    }

		    _db.DiseaseTreatments.Update(diseaseTreatment);
		    _db.SaveChanges();

		    return Ok(diseaseTreatment);
	    }

	    [HttpDelete("diseaseTreatment/{id}")]
	    public IActionResult DeleteDiseaseTreatment(int id)
	    {
		    DiseaseTreatment diseaseTreatment = _db.Find<DiseaseTreatment>(id);

		    if (diseaseTreatment == null)
		    {
			    return NotFound();
		    }

		    _db.DiseaseTreatments.Remove(diseaseTreatment);
		    _db.SaveChanges();

		    return Ok();
	    }

	    [HttpGet("medicament/{id}")]
	    public ActionResult<Medicament> GetMedicament(int id)
	    {
		    Medicament medicament = _db.Medicaments.FirstOrDefault(e => e.Id == id);

		    if (medicament == null)
		    {
			    return NotFound();
		    }

		    return Ok(medicament);
	    }

	    [HttpGet("medicaments")]
	    public IEnumerable<Medicament> GetMedicaments()
	    {
		    return _db.Medicaments;
	    }

	    [HttpPost("medicament")]
	    public ActionResult<Medicament> PostMedicament([FromBody] Medicament medicament)
	    {
		    Medicament oldMedicament = _db.Find<Medicament>(medicament.Id);

		    if (oldMedicament != null)
		    {
			    return BadRequest();
		    }

		    _db.Medicaments.Add(medicament);
		    _db.SaveChanges();

		    return Ok(medicament);
	    }

	    [HttpPut("medicament")]
	    public ActionResult<Medicament> UpdateMedicament([FromBody] Medicament medicament)
	    {
		    if (!_db.Medicaments.Any(e => e.Id == medicament.Id))
		    {
			    return NotFound();
		    }

		    _db.Medicaments.Update(medicament);
		    _db.SaveChanges();

		    return Ok(medicament);
	    }

	    [HttpDelete("medicament/{id}")]
	    public IActionResult DeleteMedicament(int id)
	    {
		    Medicament medicament = _db.Find<Medicament>(id);

		    if (medicament == null)
		    {
			    return NotFound();
		    }

		    _db.Medicaments.Remove(medicament);
		    _db.SaveChanges();

		    return Ok();
	    }

	    [HttpGet("disease/{id}")]
	    public ActionResult<Disease> GetDisease(int id)
	    {
		    Disease disease = _db.Diseases.FirstOrDefault(e => e.Id == id);

		    if (disease == null)
		    {
			    return NotFound();
		    }

		    return Ok(disease);
	    }

	    [HttpGet("diseases")]
	    public IEnumerable<Disease> GetDiseases()
	    {
		    return _db.Diseases;
	    }

	    [HttpPost("disease")]
	    public ActionResult<Disease> PostDisease([FromBody] Disease disease)
	    {
		    Disease oldDisease = _db.Find<Disease>(disease.Id);

		    if (oldDisease != null)
		    {
			    return BadRequest();
		    }

		    _db.Diseases.Add(disease);
		    _db.SaveChanges();

		    return Ok(disease);
	    }

	    [HttpPut("disease")]
	    public ActionResult<Disease> UpdateDisease([FromBody] Disease disease)
	    {
		    if (!_db.Diseases.Any(e => e.Id == disease.Id))
		    {
			    return NotFound();
		    }

		    _db.Diseases.Update(disease);
		    _db.SaveChanges();

		    return Ok(disease);
	    }

	    [HttpDelete("disease/{id}")]
	    public IActionResult DeleteDisease(int id)
	    {
		    Disease disease = _db.Find<Disease>(id);

		    if (disease == null)
		    {
			    return NotFound();
		    }

		    _db.Diseases.Remove(disease);
		    _db.SaveChanges();

		    return Ok();
	    }

	}
}