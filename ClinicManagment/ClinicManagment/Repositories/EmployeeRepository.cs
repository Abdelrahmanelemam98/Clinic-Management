namespace ClinicManagment.Repositories;

public class EmployeeRepository:IEmployeeRepository
{
	private readonly ApplicationDbContext _context;

	public EmployeeRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task<Employee> CreateAsync(Employee employee)
	{
		await _context.AddAsync(employee);
		await _context.SaveChangesAsync();
		return employee;
	}

	public Employee DeleteAsync(Employee employee)
	{
		_context.Remove(employee);
		_context.SaveChanges();
		return employee;
	}

	public async Task<IEnumerable<Employee>> GetAllAsync()
	{
		return (await _context.employees.OrderByDescending(e=>e.Salary).ToListAsync());
	}

	public async Task<Employee> GetById(Guid id)
	{
		var employee = await _context.employees.SingleOrDefaultAsync(c => c.Id == id);
		if (employee == null)
			return null;
		return employee;
	}

	public Employee UpdateAsync(Employee employee)
	{
		_context.employees.Update(employee);
		_context.SaveChanges();
		return employee;
	}
}
