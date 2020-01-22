using mvcConsoleCS.Models.Entities;
using System.Data.Entity;

namespace mvcConsoleCS.Models
{
	public class Context : DbContext
	{
		public virtual DbSet<Address> Addresses { get; set; }
	}
}
