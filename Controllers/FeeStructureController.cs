using AdmissionProcess.Entity;
using AdmissionProcess.Services.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdmissionProcess.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FeeStructureController : ControllerBase
	{
		private readonly IFeeStructureServices feeStructureServices;
		public FeeStructureController(IFeeStructureServices feeStructureServices)
		{
			this.feeStructureServices = feeStructureServices;
		}

		// GET: api/<RegisterController>
		[HttpGet]
		[Route("GetAllFeeStructures")]
		public IActionResult Get()
		{
			try
			{
				return new ObjectResult(feeStructureServices.GetAllFeeStructures());
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex.Message);
			}
		}

		// GET api/<RegisterController>/5
		[HttpGet]
		[Route("GetFeeStructureById/{id}")]
		public IActionResult Get(int Payment_ID)
		{
			try
			{
				return new ObjectResult(feeStructureServices.GetFeeStructureById(Payment_ID));
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex.Message);
			}
		}
		// POST api/<RegisterController>
		[HttpPost]
		[Route("AddFeeStructure")]

		public IActionResult Post([FromBody] FeeStructure feeStructure)
		{
			try
			{
				int res = feeStructureServices.AddFeeStructure(feeStructure);
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
		[Route("UpdateFeeStructure")]

		public IActionResult Put([FromBody] FeeStructure feeStructure)
		{
			try
			{
				int res = feeStructureServices.UpdateFeeStructure(feeStructure);
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
		[Route("DeleteFeeStructure/{id}")]
		public IActionResult Delete(int Payment_ID)
		{
			try
			{
				int result = feeStructureServices.DeleteFeeStructure(Payment_ID);
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
