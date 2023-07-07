namespace ClinicManagment.Repositories.Contracts;

public interface ICategoryRepository
{
	Task<IEnumerable<Category>> GetAllAsync();
	Task<Category> GetById(Guid id);
	Task<Category> CreateAsync(Category category);
	Category UpdateAsync(Category category);
	Category DeleteAsync(Category category);
}
