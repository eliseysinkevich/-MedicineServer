using System.Collections.Generic;
using System.Linq;
using MedicineServer.Model;
using Microsoft.AspNetCore.Mvc;

namespace MedicineServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParameterController : ControllerBase
	{
		private readonly MedicineContext _db;

		public ParameterController(MedicineContext context)
		{
			_db = context;
		}

		[HttpGet("parameter/{id}")]
	    public ActionResult<Parameter> GetParameter(int id)
	    {
		    Parameter parameter = _db.Parameters.FirstOrDefault(e => e.Id == id);

		    if (parameter == null)
		    {
			    return NotFound();
		    }

		    return Ok(parameter);
	    }

	    [HttpGet("parameters")]
	    public IEnumerable<Parameter> GetParameters()
	    {
		    return _db.Parameters;
	    }

	    [HttpPost("parameter")]
	    public ActionResult<Parameter> PostParameter([FromBody] Parameter parameter)
	    {
		    Parameter oldParameter = _db.Find<Parameter>(parameter.Id);

		    if (oldParameter != null)
		    {
			    return BadRequest();
		    }

		    _db.Parameters.Add(parameter);
		    _db.SaveChanges();

		    return Ok(parameter);
	    }

	    [HttpPut("parameter")]
	    public ActionResult<Parameter> UpdateParameter([FromBody] Parameter parameter)
	    {
		    if (!_db.Parameters.Any(e => e.Id == parameter.Id))
		    {
			    return NotFound();
		    }

		    _db.Parameters.Update(parameter);
		    _db.SaveChanges();

		    return Ok(parameter);
	    }

	    [HttpDelete("parameter/{id}")]
	    public IActionResult DeleteParameter(int id)
	    {
		    Parameter parameter = _db.Find<Parameter>(id);

		    if (parameter == null)
		    {
			    return NotFound();
		    }

		    _db.Parameters.Remove(parameter);
		    _db.SaveChanges();

		    return Ok();
	    }
	}
}