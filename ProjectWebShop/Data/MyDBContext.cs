using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Model;
using WebApiMyShop.Models;

namespace WebApiMyShop.Data
{
    public class MyDBContext: DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }
        public MyDBContext() { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<LineProducts> LineProducts { get; set; }
        public DbSet<ImageProducts> ImageProducts { get; set; }
        public DbSet<Evaluates> Evaluates { get; set; }
        public DbSet<ImgComments> Imgcomments { get; set; }
    }
}
