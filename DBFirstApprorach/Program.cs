
using DBFirstApprorach.Contexts;

namespace DBFirstApprorach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region BD first With Command 

            /*
             * Download Package Manager Console
             * - Install-Package Microsoft.EntityFrameworkCore.SqlServer
             * - Install-Package Microsoft.EntityFrameworkCore.Tools
             * - Install-Package Microsoft.EntityFrameworkCore.Proxies
             * 
             * 2- use DB Northwid =>Scaffold =>package Manager Console
             
             */

            //get all products name 

            //using MyNorthwindDbContext myNorthwindDbContext = new MyNorthwindDbContext();
            //var products = myNorthwindDbContext.Products.ToList();

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            #endregion

            #region DB First With EF core Power Tools

            /*
             * 1- Install EF Core Power Tools from Extensions
             *
             *
             */

            using MyNorthwindDBContext myNorthwindDbContext = new MyNorthwindDBContext();
            var products = myNorthwindDbContext.Products.ToList();
            foreach (var item in products)
            {
                Console.WriteLine(item.ProductName);
            }

            #endregion


        }
    }
}
