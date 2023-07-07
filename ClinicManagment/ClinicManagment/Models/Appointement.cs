namespace ClinicManagment.Models
{
	public class Appointement
	{
		public int Id { get; set; }
		public Doctor Doctor { get; set; }
		public  DateTime date { get; set; }
	}
}
