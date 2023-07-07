using System.Collections;
using System.Collections.Generic;

namespace ClinicManagment.Models
{
	public class Doctor
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Gender { get; set; }
		[Required]
		public int Age { get; set; }
		[Required]
		public string Spectialization { get; set; }
		[Required]
		public string Degree { get; set; }
		[Required]
		public double Rate { get; set; }
		[Required,MaxLength(200)]
		public string Address { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
		[Required]
		public string Img { get; set; }
		[Required]
		public string WorkExperiences { get ; set;}
		[Required]
		public string Awards { get; set; }
		[Required]
		public string Services { get; set; }
		[Required,MaxLength(800)]
		public string Description { get; set; }
		[Required]
		public string Email { get; set; }
	}
}
