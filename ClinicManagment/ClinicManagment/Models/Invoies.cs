namespace ClinicManagment.Models
{
	public class Invoies
	{
		public int Id { get; set; }
		public Doctor doctor { get; set; }
		public Patient patient { get; set; }
		public Employee employee { get; set; }
		[Required]
		public DateTime date { get; set; }
		[Required]
		public double TotalPrice { get; set; }
		[Required]
		public double Discount { get; set; }
	}
}
