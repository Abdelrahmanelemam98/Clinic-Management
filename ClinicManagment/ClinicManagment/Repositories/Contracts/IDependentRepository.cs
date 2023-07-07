namespace ClinicManagment.Repositories.Contracts;

public interface IDependentRepository
{
	Task<IEnumerable<Dependent>> GetAllAsync();
	Task<Dependent> GetById(Guid id);
	Task<Dependent> CreateAsync(Dependent dependent);
	Dependent UpdateAsync(Dependent dependent);
	Dependent DeleteAsync(Dependent dependent);
}
