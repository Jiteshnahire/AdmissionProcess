using AdmissionProcess.Entity;
using AdmissionProcess.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdmissionProcess.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AdmissionFormController : ControllerBase
	{
		private readonly IAdmissionFormServices admissionFormServices;
		public AdmissionFormController(IAdmissionFormServices admissionFormServices)
		{
			this.admissionFormServices = admissionFormServices;
		}

		// GET: api/<RegisterController>
		[HttpGet]
		[Route("GetAllAdmissionForms")]
		public IActionResult Get()
		{
			try
			{
				return new ObjectResult(admissionFormServices.GetAllAdmissionForms());
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex.Message);
			}
		}

		// GET api/<RegisterController>/5
		[HttpGet]
		[Route("GetAdmissionFormById/{id}")]
		public IActionResult Get(int Student_ID)
		{
			try
			{
				return new ObjectResult(admissionFormServices.GetAdmissionFormById(Student_ID));
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex.Message);
			}
		}
		// POST api/<RegisterController>
		[HttpPost]
		[Route("AddAdmissionForms")]

		public IActionResult AddAdmissionForms([FromBody] AdmissionForm admissionForm)
		{
			try
			{
				int res = admissionFormServices.AddAdmissionForms(admissionForm);
				if (res >= 1)
				{
					return StatusCode(StatusCodes.Status201Created);
				}
				else
				{
					return StatusCode(StatusCodes.Status500InternalServerError);
				}
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

		// PUT api/<RegisterController>/5
		[HttpPut]
		[Route("UpdateAdmissionForms")]

		public IActionResult Put([FromBody] AdmissionForm admissionForm)
		{
			try
			{
				int res = admissionFormServices.UpdateAdmissionForms(admissionForm);
				if (res >= 1)
				{
					return StatusCode(StatusCodes.Status201Created);
				}
				else
				{
					return StatusCode(StatusCodes.Status500InternalServerError);
				}
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		[HttpDelete]
		[Route("DeleteAdmissionForms/{id}")]
		public IActionResult Delete(int Student_ID)
		{
			try
			{
				int result = admissionFormServices.DeleteAdmissionForms(Student_ID);
				if (result >= 1)
				{
					return StatusCode(StatusCodes.Status200OK);

				}
				else
				{
					return StatusCode(StatusCodes.Status500InternalServerError);
				}


			}
			catch (Exception ex)
			{

				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

			}
		}
	}
}