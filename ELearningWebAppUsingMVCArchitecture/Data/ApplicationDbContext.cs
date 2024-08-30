using ELearningWebAppUsingMVCArchitecture.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningWebAppUsingMVCArchitecture.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options): base(options) 
		{
			
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Categories> Categories { get; set; }

        public DbSet<Sub_Categories> Sub_Categories { get; set; }
    }
}
