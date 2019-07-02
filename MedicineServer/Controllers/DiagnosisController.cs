using System.Collections.Generic;
using System.Linq;
using MedicineServer.Model;
using Microsoft.AspNetCore.Mvc;


namespace MedicineServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DiagnosisController : ControllerBase
    {
	    private readonly MedicineContext _db;

	    public DiagnosisController(MedicineContext context)
	    {
		    _db = context;
	    }

	    [HttpGet("diagnosis/{id}")]
	    public ActionResult<Diagnosis> GetDiagnosis(int id)
	    {
		    Diagnosis diagnosis = _db.Diagnoses.FirstOrDefault(e => e.Id == id);

		    if (diagnosis == null)
		    {
			    return NotFound();
		    }

		    return Ok(diagnosis);
	    }

	    [HttpGet("diagnosiss")]
	    public IEnumerable<Diagnosis> GetDiagnosiss()
	    {
		    return _db.Diagnoses;
	    }

	    [HttpPost("diagnosis")]
	    public ActionResult<Diagnosis> PostDiagnosis([FromBody] Diagnosis diagnosis)
	    {
		    Diagnosis oldDiagnosis = _db.Find<Diagnosis>(diagnosis.Id);

		    if (oldDiagnosis != null)
		    {
			    return BadRequest();
		    }

		    _db.Diagnoses.Add(diagnosis);
		    _db.SaveChanges();

		    return Ok(diagnosis);
	    }

	    [HttpPut("diagnosis")]
	    public ActionResult<Diagnosis> UpdateDiagnosis([FromBody] Diagnosis diagnosis)
	    {
		    if (!_db.Diagnoses.Any(e => e.Id == diagnosis.Id))
		    {
			    return NotFound();
		    }

		    _db.Diagnoses.Update(diagnosis);
		    _db.SaveChanges();

		    return Ok(diagnosis);
	    }

	    [HttpDelete("diagnosis/{id}")]
	    public IActionResult DeleteDiagnosis(int id)
	    {
		    Diagnosis diagnosis = _db.Find<Diagnosis>(id);

		    if (diagnosis == null)
		    {
			    return NotFound();
		    }

		    _db.Diagnoses.Remove(diagnosis);
		    _db.SaveChanges();

		    return Ok();
	    }

	    [HttpGet("diagnosisDisease/{id}")]
	    public ActionResult<DiagnosisDisease> GetDiagnosisDisease(int id)
	    {
		    DiagnosisDisease diagnosisDisease = _db.DiagnosisDiseases.FirstOrDefault(e => e.Id == id);

		    if (diagnosisDisease == null)
		    {
			    return NotFound();
		    }

		    return Ok(diagnosisDisease);
	    }

	    [HttpGet("diagnosisDiseases")]
	    public IEnumerable<DiagnosisDisease> GetDiagnosisDiseases()
	    {
		    return _db.DiagnosisDiseases;
	    }

	    [HttpPost("diagnosisDisease")]
	    public ActionResult<DiagnosisDisease> PostDiagnosisDisease([FromBody] DiagnosisDisease diagnosisDisease)
	    {
		    DiagnosisDisease oldDiagnosisDisease = _db.Find<DiagnosisDisease>(diagnosisDisease.Id);

		    if (oldDiagnosisDisease != null)
		    {
			    return BadRequest();
		    }

		    _db.DiagnosisDiseases.Add(diagnosisDisease);
		    _db.SaveChanges();

		    return Ok(diagnosisDisease);
	    }

	    [HttpPut("diagnosisDisease")]
	    public ActionResult<DiagnosisDisease> UpdateDiagnosisDisease([FromBody] DiagnosisDisease diagnosisDisease)
	    {
		    if (!_db.DiagnosisDiseases.Any(e => e.Id == diagnosisDisease.Id))
		    {
			    return NotFound();
		    }

		    _db.DiagnosisDiseases.Update(diagnosisDisease);
		    _db.SaveChanges();

		    return Ok(diagnosisDisease);
	    }

	    [HttpDelete("diagnosisDisease/{id}")]
	    public IActionResult DeleteDiagnosisDisease(int id)
	    {
		    DiagnosisDisease diagnosisDisease = _db.Find<DiagnosisDisease>(id);

		    if (diagnosisDisease == null)
		    {
			    return NotFound();
		    }

		    _db.DiagnosisDiseases.Remove(diagnosisDisease);
		    _db.SaveChanges();

		    return Ok();
	    }

	    [HttpGet("symptom/{id}")]
	    public ActionResult<Symptom> GetSymptom(int id)
	    {
		    Symptom symptom = _db.Symptoms.FirstOrDefault(e => e.Id == id);

		    if (symptom == null)
		    {
			    return NotFound();
		    }

		    return Ok(symptom);
	    }

	    [HttpGet("symptoms")]
	    public IEnumerable<Symptom> GetSymptoms()
	    {
		    return _db.Symptoms;
	    }

	    [HttpPost("symptom")]
	    public ActionResult<Symptom> PostSymptom([FromBody] Symptom symptom)
	    {
		    Symptom oldSymptom = _db.Find<Symptom>(symptom.Id);

		    if (oldSymptom != null)
		    {
			    return BadRequest();
		    }

		    _db.Symptoms.Add(symptom);
		    _db.SaveChanges();

		    return Ok(symptom);
	    }

	    [HttpPut("symptom")]
	    public ActionResult<Symptom> UpdateSymptom([FromBody] Symptom symptom)
	    {
		    if (!_db.Symptoms.Any(e => e.Id == symptom.Id))
		    {
			    return NotFound();
		    }

		    _db.Symptoms.Update(symptom);
		    _db.SaveChanges();

		    return Ok(symptom);
	    }

	    [HttpDelete("symptom/{id}")]
	    public IActionResult DeleteSymptom(int id)
	    {
		    Symptom symptom = _db.Find<Symptom>(id);

		    if (symptom == null)
		    {
			    return NotFound();
		    }

		    _db.Symptoms.Remove(symptom);
		    _db.SaveChanges();

		    return Ok();
	    }
    }
}