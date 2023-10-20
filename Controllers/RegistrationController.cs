using AdmissionProcess.Entity;
using AdmissionProcess.Services.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdmissionProcess.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RegistrationController : ControllerBase
	{
		private readonly IRegistrationServices registrationServices;
		public RegistrationController(IRegistrationServices registrationServices)
		{
			this.registrationServices = registrationServices;
		}

		// GET: api/<RegisterController>
		[HttpGet]
		[Route("GetAllRegistrations")]
		public IActionResult Get()
		{
			try
			{
				return new ObjectResult(registrationServices.GetAllRegistrations());
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex.Message);
			}
		}

		// GET api/<RegisterController>/5
		[HttpGet]
		[Route("GetRegistrationById/{id}")]
		public IActionResult Get(int Admin_ID)
		{
			try
			{
				return new ObjectResult(registrationServices.GetRegistrationById(Admin_ID));
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex.Message);
			}
		}
		// POST api/<RegisterController>
		[HttpPost]
		[Route("AddRegistration")]

		public IActionResult Post([FromBody] Registration registration)
		{
			try
			{
				int res = registrationServices.AddRegistration(registration);
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
		[Route("UpdateRegistration")]

		public IActionResult Put([FromBody] Registration registration)
		{
			try
			{
				int res = registrationServices.UpdateRegistration(registration);
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
		[Route("DeleteRegistration/{id}")]
		public IActionResult Delete(int Admin_ID)
		{
			try
			{
				int result = registrationServices.DeleteRegistration(Admin_ID);
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

