using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmissionProcess.Repository
{
	[Table("FeeStructure")]
	public class FeeStructureDto
	{
		[Key]
		public int Payment_ID { get; set; }
		[Required]
		public string? Payment_options { get; set; }
		[Required]
		public string? Current_status { get; set; }
		[Required]
		public int Amount { get; set; }
		[Required]
		public int Student_ID { get; set; }
		[Required]
		public int Add_amount { get; set; }
	}
}
