namespace ClinicManagment.Models;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}
	public DbSet<City> cities { get; set; }
	public DbSet<Category> categories { get; set; }
	public DbSet<Employee> employees { get; set; }
	public DbSet<Dependent> dependents { get; set; }
	public DbSet <Doctor> doctors { get; set; }
	public DbSet<Clinic> clinics { get; set; }
	public DbSet<Appointement> appointements { get; set;}
	public DbSet <Medicine> medicines { get; set; }
	public DbSet<Prescription> prescriptions { get; set; }
	public DbSet<Patient> patients { get; set; }
	public DbSet <WishList> wishlist { get; set; }
	public DbSet<Invoies> invoies { get; set; }
}
