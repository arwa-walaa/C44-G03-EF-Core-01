using InhertanceMapping.Context;

namespace InhertanceMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyContext context = new CompanyContext();
            #region Inhertence Mapping

            #region Table Per Concrete Type [TPCT]

            //FullTimeEmployee fte = new FullTimeEmployee()
            //{
            //    Name = "Arwa",
            //    Address = "Cairo",
            //    Age = 30,
            //    Salary = 10000,
            //    StartDate = DateTime.Now
            //};
            //PartTimeEmployee pte = new PartTimeEmployee()
            //{
            //    Name = "Mohamed",
            //    Address = "Giza",
            //    Age = 28,
            //    HourlyRate = 100,
            //    CountOfHours = 160
            //};

            //context.FullTimeEmployees.Add(fte);
            //context.PartTimeEmployees.Add(pte);
            //context.SaveChanges();

            //var FET = (from fe in context.FullTimeEmployees
            //           select fe).FirstOrDefault();
            //var PTE = context.PartTimeEmployees.FirstOrDefault();
            // Console.WriteLine($"FTE: {FET.Name}, Salary: {FET.Salary}, StartDate: {FET.StartDate}");   
            //    Console.WriteLine($"PTE: {PTE.Name}, HourlyRate: {PTE.HourlyRate}, CountOfHours: {PTE.CountOfHours}");



            #endregion

            #region Table Per Hierarchy [TPH]

            //FullTimeEmployee fte = new FullTimeEmployee()
            //{
            //    Name = "Arwa",
            //    Address = "Cairo",
            //    Age = 30,
            //    Salary = 10000,
            //    StartDate = DateTime.Now
            //};
            //PartTimeEmployee pte = new PartTimeEmployee()
            //{
            //    Name = "Mohamed",
            //    Address = "Giza",
            //    Age = 28,
            //    HourlyRate = 100,
            //    CountOfHours = 160
            //};

            //context.Add(fte);
            //context.Add(pte);
            //context.SaveChanges();

            //var Emps = from E in context.Employees
            //          select E;

            //foreach (var emp in Emps.OfType<FullTimeEmployee>())
            //    Console.WriteLine(emp.Name);





            #endregion
            #region Table Per Type [TPT]
            //FullTimeEmployee fte = new FullTimeEmployee()
            //{
            //    Name = "Arwa",
            //    Address = "Cairo",
            //    Age = 30,
            //    Salary = 10000,
            //    StartDate = DateTime.Now
            //};
            //PartTimeEmployee pte = new PartTimeEmployee()
            //{
            //    Name = "Mohamed",
            //    Address = "Giza",
            //    Age = 28,
            //    HourlyRate = 100,
            //    CountOfHours = 160
            //};

            //context.Add(fte);
            //context.Add(pte);
            //context.SaveChanges();

            //var Emps = (from E in context.Employees
            //           select E).ToList();
            //foreach(var E in Emps.OfType<PartTimeEmployee>()) {
            //    Console.WriteLine(E.Name);
            //}

            #endregion

            #region Local

            #region Ex01



            //var Emps = context.Employees.Any(E=>E.Age != null);

            //Console.WriteLine(Emps);

            ////local
            //var Emps = context.Employees.Local.Any(E => E.Age != null);
            //Console.WriteLine(Emps);
            #endregion

            #region Ex02



            //var Emps = context.Employees.Any(E=>E.Age != null);

            //Console.WriteLine(Emps);
            //var Emps01 = context.Employees.FirstOrDefault();
            //if(Emps01 != null)
            //{
            //    Console.WriteLine(Emps01.Age);
            //    Emps01.Age = null;
            //}

            //var Emps = context.Employees.Any(E => E.Age != null);
            //Console.WriteLine($"DB {Emps}" );
            ////local
            //var LocalEmps = context.Employees.Local.Any(E => E.Age != null);
            //Console.WriteLine(LocalEmps);
            #endregion

            #endregion



            #endregion
        }

    }
    }

