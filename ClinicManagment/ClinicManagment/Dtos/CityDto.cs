namespace ClinicManagment.Dtos;

public class CityDto
{
	[Required, MaxLength(20)]
	public string Name { get; set; }

	[Required]
	public string ZipCode { get; set; }

}
