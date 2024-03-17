using System;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions options):base(options)
		{
		}

		public DbSet<Transation> Transations { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}

