namespace ClinicManagment.Models;

public class Category
{
	public Guid? Id { get; set; }= Guid.NewGuid();

	[Required,MaxLength(15)]
	public string Name { get; set; }
}
