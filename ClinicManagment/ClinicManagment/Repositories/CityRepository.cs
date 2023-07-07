namespace ClinicManagment.Repositories;

public class CityRepository : ICityRepository
{
	private readonly ApplicationDbContext _context;

	public CityRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task<City> CreateAsync(City city)
	{
		await _context.AddAsync(city);
		await _context.SaveChangesAsync();
		return city;
	}

	public City DeleteAsync(City city)
	{
		_context.Remove(city);
		_context.SaveChanges();
		return city;
	}

	public async Task<IEnumerable<City>> GetAllAsync()
	{
		return (await _context.cities.ToListAsync());
	}

	public async Task<City> GetById(Guid id)
	{
		var city = await _context.cities.SingleOrDefaultAsync(c => c.Id == id);
		if (city == null)
			return null;
		return city;
	}

	public City UpdateAsync(City city)
	{
		_context.cities.Update(city);
		_context.SaveChanges();
		return city;
	}
}
