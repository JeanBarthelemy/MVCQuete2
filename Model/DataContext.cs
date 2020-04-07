using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace MVCQuete2.Model
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Product> ProductsList { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=MVCProductsDB;Integrated Security=True");
        }
    }
}
