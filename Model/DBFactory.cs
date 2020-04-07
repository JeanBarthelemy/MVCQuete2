using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCQuete2.Model
{
    class DBFactory
    {
        public static void CreateDB()
        {
            using (var context = new DataContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var product1 = new Product()
                {
                    Name = "1 kg oranges",
                    Price = 3.59,
                };

                var product2 = new Product()
                {
                    Name = "2 kg strawberries",
                    Price = 16.99,
                };

                var product3 = new Product()
                {
                    Name = "1 kg flour",
                    Price = 2.29,
                };

                var product4 = new Product()
                {
                    Name = "Pack of toilet paper",
                    Price = 99.99,
                };

                List<Product> productList = new List<Product>();
                
                context.Add(product1);
                context.Add(product2);
                context.Add(product3);
                context.Add(product4);

                context.SaveChanges();

            }
        }
    }
}
