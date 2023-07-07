namespace ClinicManagment.Models;

public class City
{
	public Guid? Id { get; set; } = Guid.NewGuid();

	[Required, MaxLength(20)]
	public string Name { get; set; }

	[Required]
	public string ZipCode { get; set; }
}
