using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmissionProcess.Repository
{
	[Table("Registration")]
	public class RegistrationDto
	{
		[Key]
		public int Admin_ID { get; set; }
		[Required]
		public string? Fullname { get; set; }
		[Required]
		public int Mobile { get; set; }
		[Required]
		public string? Email { get; set; }
		[Required]
		public string? Password { get; set; }
		[Required]
		public string? Reg_Date { get; set; }
		[Required]
		public string? Admin_status { get; set; }
	}
}
