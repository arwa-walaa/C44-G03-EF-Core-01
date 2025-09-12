using EFCoreSession1.Context;
using EFCoreSession1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EFCoreSession1.Data
{
    internal class CompanyDBContextSeed
    {
        public static bool seed(CompanyDBContext  companyDBContext )
        {
            try { 
                if(!companyDBContext.Employees.Any())
                {
                    var EmpData = File.ReadAllText("files\\employees.json");
                    var Employees = JsonSerializer.Deserialize<List<Employee>>(EmpData);
                    if (Employees.Count>0)
                    {
                        companyDBContext.AddRange(Employees);
                        companyDBContext.SaveChanges();

                    }

                }
                return true;
            }
            catch(Exception) { 
                return false;

            
            }
        }
    }
}
