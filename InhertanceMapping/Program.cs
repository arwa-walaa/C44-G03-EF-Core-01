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

            var FET = (from fe in context.FullTimeEmployees
                       select fe).FirstOrDefault();
            var PTE = context.PartTimeEmployees.FirstOrDefault();
             Console.WriteLine($"FTE: {FET.Name}, Salary: {FET.Salary}, StartDate: {FET.StartDate}");   
                Console.WriteLine($"PTE: {PTE.Name}, HourlyRate: {PTE.HourlyRate}, CountOfHours: {PTE.CountOfHours}");



            #endregion

            #endregion

        }
    }
}
