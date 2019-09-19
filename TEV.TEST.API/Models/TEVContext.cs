using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace TEV.TEST.API.Models
{
	public class TEVContext : DbContext
	{

		public TEVContext(DbContextOptions<TEVContext> options)
			: base(options)
		{
		}

		public DbSet<User> Users { get; set; }

	}
}
