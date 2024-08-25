using System;
using Microsoft.EntityFrameworkCore;
using WebapiDemo.Models;

namespace WebapiDemo.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base (options)
		{
		}

		public DbSet<Products> Products => Set<Products>();
	}
}

