namespace ClinicManagment.Repositories;

public class CategoryRepository : ICategoryRepository
{

	private readonly ApplicationDbContext _context;

	public CategoryRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task<Category> CreateAsync(Category category)
	{
		await _context.AddAsync(category);
		await _context.SaveChangesAsync();
		return category;
	}

	public Category DeleteAsync(Category category)
	{
		_context.Remove(category);
		_context.SaveChanges();
		return category;
	}

	public async Task<IEnumerable<Category>> GetAllAsync()
	{
		return (await _context.categories.OrderBy(c=>c.Name).ToListAsync());
	}

	public async Task<Category> GetById(Guid id)
	{
		var category = await _context.categories.SingleOrDefaultAsync(c => c.Id == id);
		if (category == null)
			return null;
		return category;
	}

	public Category UpdateAsync(Category category)
	{
		_context.categories.Update(category);
		_context.SaveChanges();
		return category;
	}
}
