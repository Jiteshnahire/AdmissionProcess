using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmissionProcess.Entity
{
	[Table("FeeStructure")]
	public class FeeStructure
	{
		[Key]
		public int Payment_ID { get; set; }
		[Required]

		public string? Payment_options { get; set; }
		[Required]
		public int Current_status { get; set; }
		[Required]
		public string? Amount { get; set; }
		[Required]
		public int Student_ID { get; set; }
		[Required]
		public string? Add_amount { get; set; }
	}
}

