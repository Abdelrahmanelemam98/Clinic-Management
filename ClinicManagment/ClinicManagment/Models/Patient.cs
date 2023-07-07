namespace ClinicManagment.Models
{
	public class Patient
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required,MaxLength(200)]
		public string Address { get; set; }
		[Required]
		public string Age { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string BloodGroup { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
		[Required]
		public string Img { get; set; }

		public string? HeartRate { get ; set; }	
		public string?Temporary { get; set; }
		[Required]
		public string Weight { get ; set; }
		[Required]
		public string Heigth { get; set; }
		[Required]
		public string Gender { get; set; }
		[Required]
		public string BloodPressure { get; set; }
		[Required]
		public string Type { get; set; }	

	}
}
