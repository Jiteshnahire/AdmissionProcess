﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmissionProcess.Entity
{
	[Table("AdmissionForm")]
	public class AdmissionForm
	{
		[Key]
		public int Student_ID { get; set; }
		[Required]
		public string? Fullname { get; set; }
		[Required]
		public string? Email { get; set; }
		[Required]
		public int Age { get; set; }
		[Required]
		public string? Gender { get; set; }
		[Required]
		public string? DOB { get; set; }
		[Required]
		public string? Mobile { get; set; }
		[Required]
		public string? Address { get; set; }
		[Required]

		public decimal Percentage { get; set; }
		[Required]
		public string? GPA { get; set; }
		[Required]
		public string? Branch { get; set; }
		[Required]
		public string? Religion { get; set; }
		[Required]
		public string? Previous_College { get; set; }
		[Required]
		public string? Enrollment_date { get; set; }
		[Required]
		public string? Password { get; set; }
		[Required]
		public string? Fee { get; set; }
		[Required]
		public string? Education { get; set; }
		[Required]
		public int Student_status { get; set; }
		[Required]
		public int Form_status { get; set; }


	}
}

