using EFCoreSession1.Context;
using EFCoreSession1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session01


            #region DBContext

            //CompanyDBContext dbContext = new CompanyDBContext();

            //close connection
            //try { }
            //finally
            //{
            //    dbContext.Dispose();
            //}

            //using CompanyDBContext dbContext = new CompanyDBContext();

            //dbContext.Database.Migrate();
            //to apply migration you must install the following nuget package
            //Microsoft.EntityFrameworkCore.Tools
            //in package manager console
            //Add-Migration -Name "InitialCreate" -Context "CompanyDBContext"
            //to update database
            //Update-Database -Context "CompanyDBContext"
            #endregion
            #region Migration

            /*
             * to remove Migrstion 
             * 1- you must revert this migration 
             *   Update-Database 0
             * 2- then remove migration
             *  Remove-Migration 
             * 
             */
            #endregion

            #endregion
            #region Session02

            using CompanyDBContext dbContext = new CompanyDBContext();

            Employee employee = new Employee()
            {
                Name = "John Doe",
                Age = 30,
                Salary = 9000m
            };
            dbContext.ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.TrackAll;//default
            dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //add this employee to table Employees

            // 1)

            dbContext.Employees.Add(employee);
            // 2)

            dbContext.Set<Employee>().Add(employee);

            // 3)

            dbContext.Add(employee);
            //detached, unchanged, deleted, modified, added
            Console.WriteLine($"Employee State : {dbContext.Entry<Employee>(employee).State}"); //detached

            //save changes to database
            dbContext.SaveChanges(); //added
            Console.WriteLine($"Employee State : {dbContext.Entry<Employee>(employee).State}"); //added


            #endregion

        }
    }
}
