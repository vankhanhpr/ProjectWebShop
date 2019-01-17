using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMyShop.Models;
namespace WebApiMyShop.Data
{
    public class MyDBContext: DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }
        public MyDBContext() { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ordered> Ordereds { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCatagory> ProductCatagories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
