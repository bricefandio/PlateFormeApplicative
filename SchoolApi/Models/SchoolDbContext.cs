using Microsoft.EntityFrameworkCore;

namespace SchoolApi.Models
{
	public class SchoolDbContext: DbContext
	{
		public SchoolDbContext(DbContextOptions<SchoolDbContext>options)
			:base(options) 
		{

		}

		public DbSet<Eleve> Eleves { get; set; }
		public DbSet<Groupe> Groupes { get; set;}
		public DbSet<Promotion> Promotions { get; set; }
	}
}
