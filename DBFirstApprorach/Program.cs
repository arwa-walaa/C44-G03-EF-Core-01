
using DBFirstApprorach.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DBFirstApprorach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using MyNorthwindDBContext myNorthwindDbContext = new MyNorthwindDBContext();


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
             * don't forget add  TrustServerCertificate=true
             *
             */

            //using MyNorthwindDBContext myNorthwindDbContext = new MyNorthwindDBContext();
            //var products = myNorthwindDbContext.Products.ToList();
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            #endregion

            #region Run SQL Qurires VIA Application

            using MyNorthwindDBContext myNorthwindDbContext1 = new MyNorthwindDBContext();
            #region Select
            //int categoryId = 1;
            ////var products = myNorthwindDbContext1.Products.FromSqlRaw("select * from Products where CategoryID= {0}", categoryId).ToList();

            ////$
            //var products = myNorthwindDbContext1.Products.FromSqlInterpolated($"select * from Products where CategoryID= {categoryId}" ).ToList();


            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            #endregion

            #region Update & Delete
            //int  ProdID = 1;
            //var Result = myNorthwindDbContext1.Database.ExecuteSqlInterpolated($"Update Products set ProductName= 'Ice Cofee' where ProductID={ProdID}");

            //int ProdID = 93;
            //var Result = myNorthwindDbContext1.Database.ExecuteSqlInterpolated($"Delete from Products where ProductID={ProdID}");


            //Console.WriteLine(Result);

            #endregion
            #endregion

            #region Views

            //var productsByCategories = myNorthwindDbContext1.ProductsByCategories.ToList();   
            //foreach (var item in productsByCategories)
            //{
            //    Console.WriteLine($"{item.CategoryName}--{item.ProductName}");
            //}

            //create view 



            #endregion


        }
    }
}
