using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Model;
namespace WebApiMyShop.Data
{
    public class MyDBContext: DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }
        public MyDBContext() { }
        public DbSet<Products> Products { get; set; }
        public DbSet<LineProducts> LineProducts { get; set; }
    }
}
