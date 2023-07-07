namespace ClinicManagment.Repositories.Contracts;

public class DependentRepository:IDependentRepository
{
	private readonly ApplicationDbContext _context;

	public DependentRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task<Dependent> CreateAsync(Dependent dependent)
	{
		await _context.AddAsync(dependent);
		await _context.SaveChangesAsync();
		return dependent;
	}

	public Dependent DeleteAsync(Dependent dependent)
	{
		_context.Remove(dependent);
		_context.SaveChanges();
		return dependent;
	}

	public async Task<IEnumerable<Dependent>> GetAllAsync()
	{
		return (await _context.dependents.OrderBy(c => c.Name).ToListAsync());
	}

	public async Task<Dependent> GetById(Guid id)
	{
		var dependent = await _context.dependents.SingleOrDefaultAsync(c => c.Id == id);
		if (dependent == null)
			return null;
		return dependent;
	}

	public Dependent UpdateAsync(Dependent dependent)
	{
		_context.dependents.Update(dependent);
		_context.SaveChanges();
		return dependent;
	}
}
