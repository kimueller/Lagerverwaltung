using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WarehouseManagment.Data.Models;

namespace WarehouseManagment.Data
{
	public class ApplicationDbContext : IdentityDbContext<Employee>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

        public DbSet<Employee> Employees { get; set;}
		public DbSet<Article> Articles { get; set;}
		public DbSet<BusinessCase> BusinessCases { get; set;}
		public DbSet<ProcessType> ProcessTypes { get; set;}
		public DbSet<StockMovement> StockMovements { get; set;}
	
	}


}