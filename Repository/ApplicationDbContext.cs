using AdmissionProcess.Entity;
using Microsoft.EntityFrameworkCore;

namespace AdmissionProcess.Repository
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<AdmissionForm> AdmissionForms { get; set; }

		public DbSet<Registration> Registrations { get; set; }

		public DbSet<FeeStructure> FeeStructures { get; set; }
	}
}
