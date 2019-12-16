using Microsoft.EntityFrameworkCore;
using Article.Entity.Model;

namespace Article.Entity.Core
{
	public partial class DataContext : DigiArticleContext, IDataContext
	{
		public DataContext(DbContextOptions<DigiArticleContext> options) : base(options)
		{

		}
	}
}