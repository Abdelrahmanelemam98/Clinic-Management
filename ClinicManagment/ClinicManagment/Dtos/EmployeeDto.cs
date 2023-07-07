namespace ClinicManagment.Dtos;

public class EmployeeDto
{
	[Required]
	public string Name { get; set; }

	[Required]
	public string Specialization { get; set; }

	[Required]
	public string Age { get; set; }

	[Required, MaxLength(6)]
	public string Gender { get; set; }

	[Required]
	public double Salary { get; set; }
}
