namespace ClinicManagment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CitiesController : ControllerBase
{
	private readonly ICityRepository _cityRepository;

	public CitiesController(ICityRepository cityRepository)
	{
		_cityRepository = cityRepository;
	}

	[HttpGet]
	public async Task<IActionResult> GetAllAsync() => Ok(await _cityRepository.GetAllAsync());

	[HttpGet("id")]
	public async Task<IActionResult> GetByIdAsync([FromForm] Guid id) => Ok(await _cityRepository.GetById(id));

	[HttpPost]
	public async Task<IActionResult> Create([FromForm] CityDto c)
	{
		var city = new City
		{
			Name = c.Name,
			ZipCode = c.ZipCode,
		};

		await _cityRepository.CreateAsync(city);
		return Ok(city);
	}

	[HttpPut("id")]
	public async Task<IActionResult> Update([FromForm] Guid id, [FromForm] CityDto c)
	{
		var city = await _cityRepository.GetById(id);
		city.Name = c.Name;
		city.ZipCode = c.ZipCode;

		_cityRepository.UpdateAsync(city);
		return Ok(city);
	}

	[HttpDelete("id")]
	public async Task<IActionResult> Delete([FromForm] Guid id)
	{
		var city = await _cityRepository.GetById(id);
		_cityRepository.DeleteAsync(city);
		return Ok(city);
	}
}
