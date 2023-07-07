namespace ClinicManagment.Models;

public class Dependent
{
	public Guid? Id { get; set; }= Guid.NewGuid();

	[Required]
	public string Name { get; set; }

	[Required]
	public string Relationship { get; set; }

	[Required,MaxLength(4)]
	public string Gender { get; set; }

	[Required]
	public string number { get; set; }

	[Required,MaxLength(5)]
	public string BloodGroup { get; set; }
}
