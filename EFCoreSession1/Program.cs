using EFCoreSession1.Context;
using EFCoreSession1.Data;
using EFCoreSession1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.CompilerServices;


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
            #region Dynamic Data Seeding

            bool flag = CompanyDBContextSeed.seed(dbContext);
            if (flag)
            {
                Console.WriteLine("Data Seed Done");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            #endregion


            #endregion

            #region Loading Related Data

            //var Emp01 = dbContext.Employees.FirstOrDefault(E=>E.Id==4);
            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee Name: {Emp01.Name} " );
            //    Console.WriteLine($"Department Number: {Emp01.EmpDeptId} ");
            //    Console.WriteLine($"Department Name: {Emp01.MangeDept?.DeptName} ");
            //}

            //var EmpDept = (from D in dbContext.Departments
            //              where D.DebtId== Emp01.EmpDeptId
            //              select D).FirstOrDefault();
            //Console.WriteLine($"Department Name: {EmpDept.DeptName} ");


            #region Eager Loading

            //var Emp01 = dbContext.Employees.Include(E=>E.EmployeeDepartment).FirstOrDefault(E => E.Id == 4);

            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee Name: {Emp01.Name} ");
            //    Console.WriteLine($"Department Number: {Emp01.EmpDeptId} ");
            //    Console.WriteLine($"Department Name: {Emp01.MangeDept?.DeptName} ");
            //}

            //get employee with id=6 and department which is manged by this Employee
            //var Emp06 = dbContext.Employees.Include(E => E.EmployeeDepartment).FirstOrDefault(E => E.Id == 6);
            //if (Emp06 != null)
            //{
            //    Console.WriteLine($"Employee Name: {Emp06.Name} ");
            //    Console.WriteLine($"Department Number: {Emp06.MangeDept.DebtId} ");
            //    Console.WriteLine($"Department Name: {Emp06.MangeDept?.DeptName} ");
            //}

            #endregion

            #region Explicit Loading

            #region Ex01
            //var Emp01 = dbContext.Employees.FirstOrDefault(E => E.Id == 4);
            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee Name: {Emp01.Name} ");
            //    Console.WriteLine($"Department Number: {Emp01.EmpDeptId} ");

            //    dbContext.Entry(Emp01).Reference(E=>E.EmployeeDepartment).Load();
            //    //refrence methoud alowed with one navigation property
            //    Console.WriteLine($"Department Name: {Emp01.EmployeeDepartment?.DeptName} ");
            //}
            #endregion

            #region Ex02
            var Dep01 = dbContext.Departments.FirstOrDefault(D => D.DebtId == 3);
            if (Dep01 != null)
            {
                Console.WriteLine(Dep01.DeptName);
            }
            //collection work with many nav property
            //dbContext.Entry(Dep01).Collection(D => D.Employees).Load();
            dbContext.Entry(Dep01).Collection(D => D.Employees).Query().Where(E => E.Age < 30).Load();

            foreach (var item in Dep01.Employees)
            {
                Console.WriteLine(item.Name);
            }

            #endregion

            #endregion

            #endregion

            #endregion

            #region Session04

            #region Lazy Loading

            /*
             * 1- install package Microsoft.EntityFrameworkCore.Proxies
             * 2- enable it in OnConfiguring method
             * 3-make navigation property virtual and clasess must be public 
             
             */
            //var Emp01 = dbContext.Employees.FirstOrDefault(E => E.Id == 4);
            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee Name: {Emp01.Name} ");
            //    Console.WriteLine($"Department Number: {Emp01.EmpDeptId} ");
            //    Console.WriteLine($"Department Name: {Emp01.EmployeeDepartment?.DeptName} ");
            //}

            #endregion

            #region Join Category [LINQ]

            #region Get Department that has Employees

            //var result= dbContext.Departments.Join(dbContext.Employees,
            //    D => D.DebtId,
            //    E => E.EmpDeptId,
            //    (D, E) => new
            //    { 
            //        EmpName = E.Name,
            //        EmpID=E.Id,
            //        DeptId=D.DebtId,
            //         DeptName = D.DeptName,
            //    }).ToList();

            //var result = from D in dbContext.Departments
            //           join E in dbContext.Employees
            //           on D.DebtId equals E.EmpDeptId
            //           select new
            //           {
            //               EmpName = E.Name,
            //               EmpID = E.Id,
            //               DeptId = D.DebtId,
            //               DeptName = D.DeptName,

            //           };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Get departments Mangers

            //var result = dbContext.Departments.Join(dbContext.Employees,
            //    D => D.MangerId,
            //    E => E.Id,
            //    (D, E) => new
            //    {
            //        EmpName = E.Name,
            //        EmpID = E.Id,
            //        DeptId = D.DebtId,
            //        DeptName = D.DeptName,
            //    }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion


            #region Group Join [Left outer join]

            #region Get All Departments that has Employees or not

            //var result = dbContext.Departments.GroupJoin(dbContext.Employees,
            //    D => D.DebtId,
            //    E => E.EmpDeptId,
            //    (D, Emps) => new
            //    {
            //        Department = D,

            //        Employees = Emps
            //    }).ToList();

            //var result = from D in dbContext.Departments
            //             join E in dbContext.Employees
            //             on D.DebtId equals E.EmpDeptId into Emps
            //             select new
            //             {
            //                 Department = D,
            //                 Employees = Emps
            //             };

            //foreach (var dept in result)
            //{
            //    Console.WriteLine($"DeptName : {dept.Department.DeptName}");
            //    foreach(var emp in dept.Employees)
            //    {
            //        Console.WriteLine($"   EmpName : {emp.Name}");
            //    }
            //}



            #endregion



            #endregion



            #endregion

        }
    }
}
