namespace ClinicManagment.Models;

public class Employee
{
	public Guid? Id { get; set; }= Guid.NewGuid();

	[Required]
	public string Name { get; set; }

	[Required]
	public string Specialization { get; set; }

	[Required]
	public string Age { get; set; }

	[Required,MaxLength(6)]
	public string Gender { get; set; }

	[Required]
	public double Salary { get; set; }
}
