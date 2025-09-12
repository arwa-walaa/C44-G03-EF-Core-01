using Assignment.Context;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment.Data
{
    internal class ITIDbContextSeed
    {
        public static bool seed(ITIDbContext context)
        {
            try
            {
                if (!context.Students.Any())
                {
                    Console.WriteLine("Loading students from JSON file...");
                    var EmpData = File.ReadAllText("files\\students.json");
                    var students = JsonSerializer.Deserialize<List<Student>>(EmpData);

                    if (students != null)
                    {
                        context.Students.AddRange(students);
                        context.SaveChanges();
                        Console.WriteLine("Students loaded from JSON and saved to database.");
                    }

                }
                return true;
            }
            catch (Exception)
            {
                return false;


            }
        }
    }
}