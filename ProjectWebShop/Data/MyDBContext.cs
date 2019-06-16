using Microsoft.EntityFrameworkCore;
using ProjectWebShop.Model;
using ProjectWebShop.Model.discount;
using ProjectWebShop.Model.units;
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
        public DbSet<Evaluate> Evaluates { get; set; }
        public DbSet<ImgComments> Imgcomments { get; set; }
        public DbSet<Devvn_tinhthanhpho> Devvn_tinhthanhpho { get; set; }
        public DbSet<Devvn_quanhuyen> Devvn_quanhuyen { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<InvoiceProduct> InvoiceProduct { get; set; }
        public DbSet<Describeproducts> Describeproducts { get; set; }
        public DbSet<Discount> Discount { get; set; }
    }
}
