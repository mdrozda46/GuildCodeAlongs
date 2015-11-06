using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
           // GetUSACustomers();
            AddRegion();

            Console.ReadLine();
        }

        private static void GetUSACustomers()
        {
            using (var context = new NorthwindEntities())
            {
                var USACustomers = context.Customers.Where(c => c.Country == "USA");

                foreach (var customer in USACustomers)
                {
                    Console.WriteLine("{0, -35} {1} {2}", customer.CompanyName, customer.Phone, customer.Country);
                }
            }
        }

        private static void AddRegion()
        {
            using (var context = new NorthwindEntities())
            {
                Region newRegion = new Region();
                newRegion.RegionDescription = "My New Region";

                context.Regions.Add(newRegion);
                context.SaveChanges();
            }
        }
    }
}
