namespace ClinicManagment.Repositories.Contracts;

public interface ICityRepository
{
	Task<IEnumerable<City>> GetAllAsync();
	Task<City> GetById(Guid id);
	Task<City> CreateAsync(City city);
	City UpdateAsync(City city);
	City DeleteAsync(City city);
}
