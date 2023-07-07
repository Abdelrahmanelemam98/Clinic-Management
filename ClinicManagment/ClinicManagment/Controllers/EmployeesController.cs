namespace ClinicManagment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
	private readonly IEmployeeRepository _employeeRepository;

	public EmployeesController(IEmployeeRepository employeeRepository)
	{
		_employeeRepository = employeeRepository;
	}

	[HttpGet]
	public async Task<IActionResult> GetAllAsync() => Ok(await _employeeRepository.GetAllAsync());

	[HttpGet("id")]
	public async Task<IActionResult> GetByIdAsync([FromForm] Guid id) => Ok(await _employeeRepository.GetById(id));

	[HttpPost]
	public async Task<IActionResult> Create([FromForm] EmployeeDto e)
	{
		var employee = new Employee
		{
			Name = e.Name,
			Specialization = e.Specialization,
			Age = e.Age,
			Gender = e.Gender,
			Salary = e.Salary
		};

		await _employeeRepository.CreateAsync(employee);
		return Ok(employee);
	}

	[HttpPut("id")]
	public async Task<IActionResult> Update([FromForm] Guid id, [FromForm] EmployeeDto e)
	{
		var employee = await _employeeRepository.GetById(id);
		employee.Name = e.Name;
		employee.Specialization = e.Specialization;
		employee.Age = e.Age;
		employee.Gender = e.Gender;
		employee.Salary = e.Salary;

		_employeeRepository.UpdateAsync(employee);
		return Ok(employee);
	}

	[HttpDelete("id")]
	public async Task<IActionResult> Delete([FromForm] Guid id)
	{
		var employee = await _employeeRepository.GetById(id);
		_employeeRepository.DeleteAsync(employee);
		return Ok(employee);
	}
}
