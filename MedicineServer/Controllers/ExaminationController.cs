using System.Collections.Generic;
using System.Linq;
using MedicineServer.Model;
using Microsoft.AspNetCore.Mvc;

namespace MedicineServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExaminationController : ControllerBase
    {
	    private readonly MedicineContext _db;

	    public ExaminationController(MedicineContext context)
	    {
		    _db = context;
	    }

	    [HttpGet("examination/{id}")]
	    public ActionResult<Examination> GetExamination(int id)
	    {
		    Examination examination = _db.Examinations.FirstOrDefault(e => e.Id == id);

		    if (examination == null)
		    {
			    return NotFound();
		    }

		    return Ok(examination);
	    }

	    [HttpGet("examinations")]
	    public IEnumerable<Examination> GetExaminations()
	    {
		    return _db.Examinations;
	    }

	    [HttpPost("examination")]
	    public ActionResult<Examination> PostExamination([FromBody] Examination examination)
	    {
		    Examination oldExamination = _db.Find<Examination>(examination.Id);

		    if (oldExamination != null)
		    {
			    return BadRequest();
		    }

		    _db.Examinations.Add(examination);
		    _db.SaveChanges();

		    return Ok(examination);
	    }

	    [HttpPut("examination")]
	    public ActionResult<Examination> UpdateExamination([FromBody] Examination examination)
	    {
		    if (!_db.Examinations.Any(e => e.Id == examination.Id))
		    {
			    return NotFound();
		    }

		    _db.Examinations.Update(examination);
		    _db.SaveChanges();

		    return Ok(examination);
	    }

	    [HttpDelete("examination/{id}")]
	    public IActionResult DeleteExamination(int id)
	    {
		    Examination examination = _db.Find<Examination>(id);

		    if (examination == null)
		    {
			    return NotFound();
		    }

		    _db.Examinations.Remove(examination);
		    _db.SaveChanges();

		    return Ok();
	    }

	    [HttpGet("complaint/{id}")]
	    public ActionResult<Complaint> GetComplaint(int id)
	    {
		    Complaint complaint = _db.Complaints.FirstOrDefault(e => e.Id == id);

		    if (complaint == null)
		    {
			    return NotFound();
		    }

		    return Ok(complaint);
	    }

	    [HttpGet("complaints")]
	    public IEnumerable<Complaint> GetComplaints()
	    {
		    return _db.Complaints;
	    }

	    [HttpPost("complaint")]
	    public ActionResult<Complaint> PostComplaint([FromBody] Complaint complaint)
	    {
		    Complaint oldComplaint = _db.Find<Complaint>(complaint.Id);

		    if (oldComplaint != null)
		    {
			    return BadRequest();
		    }

		    _db.Complaints.Add(complaint);
		    _db.SaveChanges();

		    return Ok(complaint);
	    }

	    [HttpPut("complaint")]
	    public ActionResult<Complaint> UpdateComplaint([FromBody] Complaint complaint)
	    {
		    if (!_db.Complaints.Any(e => e.Id == complaint.Id))
		    {
			    return NotFound();
		    }

		    _db.Complaints.Update(complaint);
		    _db.SaveChanges();

		    return Ok(complaint);
	    }

	    [HttpDelete("complaint/{id}")]
	    public IActionResult DeleteComplaint(int id)
	    {
		    Complaint complaint = _db.Find<Complaint>(id);

		    if (complaint == null)
		    {
			    return NotFound();
		    }

		    _db.Complaints.Remove(complaint);
		    _db.SaveChanges();

		    return Ok();
	    }

	    [HttpGet("doctor/{id}")]
	    public ActionResult<Doctor> GetDoctor(int id)
	    {
		    Doctor doctor = _db.Doctors.FirstOrDefault(e => e.Id == id);

		    if (doctor == null)
		    {
			    return NotFound();
		    }

		    return Ok(doctor);
	    }

	    [HttpGet("doctors")]
	    public IEnumerable<Doctor> GetDoctors()
	    {
		    return _db.Doctors;
	    }

	    [HttpPost("doctor")]
	    public ActionResult<Doctor> PostDoctor([FromBody] Doctor doctor)
	    {
		    Doctor oldDoctor = _db.Find<Doctor>(doctor.Id);

		    if (oldDoctor != null)
		    {
			    return BadRequest();
		    }

		    _db.Doctors.Add(doctor);
		    _db.SaveChanges();

		    return Ok(doctor);
	    }

	    [HttpPut("doctor")]
	    public ActionResult<Doctor> UpdateDoctor([FromBody] Doctor doctor)
	    {
		    if (!_db.Doctors.Any(e => e.Id == doctor.Id))
		    {
			    return NotFound();
		    }

		    _db.Doctors.Update(doctor);
		    _db.SaveChanges();

		    return Ok(doctor);
	    }

	    [HttpDelete("doctor/{id}")]
	    public IActionResult DeleteDoctor(int id)
	    {
		    Doctor doctor = _db.Find<Doctor>(id);

		    if (doctor == null)
		    {
			    return NotFound();
		    }

		    _db.Doctors.Remove(doctor);
		    _db.SaveChanges();

		    return Ok();
	    }
    }
}