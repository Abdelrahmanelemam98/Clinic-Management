namespace ClinicManagment.Models
{
	public class Clinic
	{
		public int Id { get; set; }
		[Required,MaxLength(100)]
		public string Title { get; set; }
		[Required]
		public double ClinicNumber { get; set; }
		[Required]
		public double Price { get; set; }
		public List <Doctor> Doctor { get; set; }
		public List < Employee> Employee { get; set; }
		public List <Appointement> Appointement { get; set;}
	}
}
