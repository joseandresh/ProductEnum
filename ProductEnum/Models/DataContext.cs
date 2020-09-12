using System.Data.Entity;

namespace ProductEnum.Models
{
	public class DataContext: DbContext
	{
		public DataContext(): base("DefaultConnection")
		{

		}

		public System.Data.Entity.DbSet<ProductEnum.Models.Product> Products { get; set; }
	}
}