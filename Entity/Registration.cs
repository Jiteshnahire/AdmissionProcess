using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmissionProcess.Entity
{
	[Table("Registration")]
	public class Registration
	{
		[Key]
		public int Admin_ID { get; set; }
		[Required]
		public string? Fullname { get; set; }
		[Required]
		public string? Mobile { get; set; }
		[Required]
		public string? Email { get; set; }
		[Required]
		public string? Password { get; set; }
		[Required]
		public string? Reg_Date { get; set; }
		[Required]
		public int Admin_status { get; set; }
	}
}

