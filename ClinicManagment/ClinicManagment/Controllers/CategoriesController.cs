namespace ClinicManagment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
	private readonly ICategoryRepository _categoryRepository;

	public CategoriesController(ICategoryRepository categoryRepository)
	{
		_categoryRepository = categoryRepository;
	}

	[HttpGet]
	public async Task<IActionResult> GetAllAsync() => Ok(await _categoryRepository.GetAllAsync());

	[HttpGet("id")]
	public async Task<IActionResult> GetByIdAsync([FromForm] Guid id) => Ok(await _categoryRepository.GetById(id));

	[HttpPost]
	public async Task<IActionResult> Create([FromForm] CategoryDto c)
	{
		var category = new Category
		{
			Name = c.Name,
		};

		await _categoryRepository.CreateAsync(category);
		return Ok(category);
	}

	[HttpPut("id")]
	public async Task<IActionResult> Update([FromForm] Guid id, [FromForm] CategoryDto c)
	{
		var category = await _categoryRepository.GetById(id);
		category.Name = c.Name;
		

		_categoryRepository.UpdateAsync(category);
		return Ok(category);
	}

	[HttpDelete("id")]
	public async Task<IActionResult> Delete([FromForm] Guid id)
	{
		var category = await _categoryRepository.GetById(id);
		_categoryRepository.DeleteAsync(category);
		return Ok(category);
	}
}
