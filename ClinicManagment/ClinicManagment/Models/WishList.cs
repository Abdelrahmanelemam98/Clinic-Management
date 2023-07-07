namespace ClinicManagment.Models
{
	public class WishList
	{
		public int Id { get; set; }	
		public Doctor doctor { get; set; }
		public Patient patient { get; set; }
	}
}
