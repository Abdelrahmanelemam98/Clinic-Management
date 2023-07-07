namespace ClinicManagment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DependentsController : ControllerBase
{
	private readonly IDependentRepository _dependentRepository;

	public DependentsController(IDependentRepository dependentRepository)
	{
		_dependentRepository = dependentRepository;
	}

	[HttpGet]
	public async Task<IActionResult> GetAllAsync() => Ok(await _dependentRepository.GetAllAsync());

	[HttpGet("id")]
	public async Task<IActionResult> GetByIdAsync([FromForm] Guid id) => Ok(await _dependentRepository.GetById(id));

	[HttpPost]
	public async Task<IActionResult> Create([FromForm] DependentDto d)
	{
		var dependent = new Dependent
		{
			Name = d.Name,
			Relationship = d.Relationship,
			Gender = d.Gender,
			BloodGroup = d.BloodGroup,
			number = d.number
			
		};

		await _dependentRepository.CreateAsync(dependent);
		return Ok(dependent);
	}

	[HttpPut("id")]
	public async Task<IActionResult> Update([FromForm] Guid id, [FromForm] DependentDto d)
	{
		var dependent = await _dependentRepository.GetById(id);
		dependent.Name = d.Name;
		dependent.Relationship = d.Relationship;
		dependent.Gender = d.Gender;
		dependent.BloodGroup = d.BloodGroup;
		dependent.number= d.number;


		_dependentRepository.UpdateAsync(dependent);
		return Ok(dependent);
	}

	[HttpDelete("id")]
	public async Task<IActionResult> Delete([FromForm] Guid id)
	{
		var dependent = await _dependentRepository.GetById(id);
		_dependentRepository.DeleteAsync(dependent);
		return Ok(dependent);
	}
}
