using EFCoreSession1.Context;
using EFCoreSession1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDBContext dbContext = new CompanyDBContext();

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

            //using CompanyDBContext dbContext = new CompanyDBContext();
            #region Add New Record


            //Employee employee = new Employee()
            //{
            //    Name = "John Doe",
            //    Age = 30,
            //    Salary = 9000m
            //};
            //dbContext.ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.TrackAll;//default
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            ////add this employee to table Employees

            //// 1)

            //dbContext.Employees.Add(employee);
            //// 2)

            //dbContext.Set<Employee>().Add(employee);

            //// 3)

            //dbContext.Add(employee);
            ////detached, unchanged, deleted, modified, added
            //Console.WriteLine($"Employee State : {dbContext.Entry<Employee>(employee).State}"); //detached

            //save changes to database
            //dbContext.SaveChanges(); //added
            //Console.WriteLine($"Employee State : {dbContext.Entry<Employee>(employee).State}"); //added
            #endregion

            #region Get Data From Table -select

            //var employee01 = dbContext.Employees.FirstOrDefault(E=>E.Id==1);
            //Console.WriteLine($"Employee Name : {employee01.Name}");

            #endregion

            #region Update Data in Table

            //var employee01 = dbContext.Employees.FirstOrDefault(E => E.Id == 1);
            //if (employee01 != null)
            //{
            //    employee01.Name = "Ali";
            //    Console.WriteLine($"Employee State : {dbContext.Entry<Employee>(employee01).State}"); //Modified
            //    Console.WriteLine($"Employee Name : {employee01.Name}");

            // dbContext.SaveChanges();

            //}

            #endregion


            #region Delete Data From Table
            //var employee03 = dbContext.Employees.FirstOrDefault(E => E.Id == 3);

            //if (employee03 != null)
            //{
            //    //dbContext.Employees.Remove(employee03);
            //    dbContext.Remove(employee03);
            //    Console.WriteLine($"Employee State : {dbContext.Entry<Employee>(employee03).State}"); //Deleted
            //    dbContext.SaveChanges();
            //}


            #endregion


            #region Relationships Between Clasess 
            /*
           * you can make Relation between 2 tables on 3 ways
           * 1-Navigation Property
           * 2-Fluent APIs
           * 3-By Conventions
           */
            #endregion

            #region One To One [Total-Total]



            #endregion




            #endregion

            #region Session03

            #region Many to One RS

            #endregion

            #region Many to Many 

            #endregion



            #region Data Seed

            /*
             * 3Ways
             * 1-Manual Data Seeding
             * 2-Migration Data Seeding
             * 3-Dynamic Data Seeding
             * */
            #region Manual Data Seeding

            //Department department1 = new Department()
            //    {
            //    DeptName = "IT",

            //     };
            //dbContext.Departments.Add(department1);
            //dbContext.SaveChanges();

            //List<Department> departments = new List<Department>()
            //{
            //    new Department(){ DeptName="HR"},
            //    new Department(){ DeptName="Finance"},
            //    new Department(){ DeptName="Marketing"},
            //    new Department(){ DeptName="Sales"},
            //};
            //dbContext.Departments.AddRange(departments);
            //dbContext.SaveChanges();

            #endregion


            #region Migration Data Seeding



            #endregion

            #endregion
            #endregion

        }
    }
}
