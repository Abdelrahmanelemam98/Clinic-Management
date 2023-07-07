namespace ClinicManagment.Models
{
	public class Prescription
	{
		public int Id { get; set; }
		public Doctor doctor { get; set; }
		[Required]
		public DateTime date { get; set; }	
		public Clinic clinic { get; set; }
		public Medicine medicine { get; set; }	
	}
}
