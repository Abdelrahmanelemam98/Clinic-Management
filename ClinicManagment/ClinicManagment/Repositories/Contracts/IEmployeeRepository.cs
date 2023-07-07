namespace ClinicManagment.Repositories.Contracts;

public interface IEmployeeRepository
{
	Task<IEnumerable<Employee>> GetAllAsync();
	Task<Employee> GetById(Guid id);
	Task<Employee> CreateAsync(Employee employee);
	Employee UpdateAsync(Employee employee);
	Employee DeleteAsync(Employee employee);
}
