namespace ClinicManagment.Models
{
	public class Medicine
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public Category Category { get; set; }
		[Required,MaxLength(100)]
		public string CompanyName { get; set; }
		[Required]
		public double Price { get; set; }
		[Required, MaxLength(100)]
		public string Description { get; set; }
		[Required]
		public DateTime ProductDate { get; set; }
		[Required]
		public DateTime ExpireDate { get; set; }

	}
}
