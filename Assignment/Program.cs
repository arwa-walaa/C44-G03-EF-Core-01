using Assignment.Context;
using Assignment.Data;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext context = new ITIDbContext();

            #region Apply Manual  Data Seed

            //// Topics
            //var topic1 = new Topic { Name = "Programming" };
            //var topic2 = new Topic { Name = "Databases" };
            //context.Topics.AddRange(topic1, topic2);
            //context.SaveChanges();

            //// Departments
            //var dept1 = new Department { Name = "Computer Science", Ins_ID = 0, HiringDate = new DateTime(2020, 1, 1) };
            //var dept2 = new Department { Name = "Information Systems", Ins_ID = 0, HiringDate = new DateTime(2021, 1, 1) };
            //context.Departments.AddRange(dept1, dept2);
            //context.SaveChanges();

            //// Instructors
            //var inst1 = new Instructor { Name = "Alice", Salary = 5000, Address = "123 Main St", HourRate = 100, Bouns = 500, Dept_ID = dept1.ID };
            //var inst2 = new Instructor { Name = "Bob", Salary = 4500, Address = "456 Elm St", HourRate = 90, Bouns = 400, Dept_ID = dept2.ID };
            //context.Instructors.AddRange(inst1, inst2);
            //context.SaveChanges();

            //// Update Ins_ID for departments (if needed for one-to-one)
            //dept1.Ins_ID = inst1.ID;
            //dept2.Ins_ID = inst2.ID;
            //context.SaveChanges();

            //// Courses
            //var course1 = new Course { Name = "C# Basics", Description = "Intro to C#", Top_ID = topic1.ID };
            //var course2 = new Course { Name = "SQL Fundamentals", Description = "Intro to SQL", Top_ID = topic2.ID };
            //context.Courses.AddRange(course1, course2);
            //context.SaveChanges();

            //// Students
            //var student1 = new Student { FName = "John", LName = "Doe", Address = "789 Oak St", Age = 20, Dep_Id = dept1.ID };
            //var student2 = new Student { FName = "Jane", LName = "Smith", Address = "321 Pine St", Age = 22, Dep_Id = dept2.ID };
            //context.Students.AddRange(student1, student2);
            //context.SaveChanges();

            //// Stud_Course (join table)
            //var sc1 = new Stud_Course { stud_ID = student1.ID, Course_ID = course1.ID, Grade = 95 };
            //var sc2 = new Stud_Course { stud_ID = student2.ID, Course_ID = course2.ID, Grade = 88 };
            //context.StudentCourses.AddRange(sc1, sc2);

            //// Course_Inst (join table)
            //var ci1 = new Course_Inst { inst_ID = inst1.ID, Course_ID = course1.ID, evaluate = "Excellent" };
            //var ci2 = new Course_Inst { inst_ID = inst2.ID, Course_ID = course2.ID, evaluate = "Good" };
            //context.CourseInstructors.AddRange(ci1, ci2);

            //context.SaveChanges();

            #endregion


            #region Dynamic Data Seed



            //bool flag = ITIDbContextSeed.seed(context);
            //if (flag)
            //{
            //    Console.WriteLine("Data Seed Done");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            #endregion

            #region Eager Loading

            // Eager loading: Students with Department 
            //var studentsWithDeptAndCourses = context.Students
            //    .Include(s => s.Department)
            //    .ToList();

            //foreach (var student in studentsWithDeptAndCourses)
            //{
            //    Console.WriteLine($"{student.FName} {student.LName} - Dept: {student.Department?.Name}");

            //}

            //// Eager loading: Courses with Topic
            //var coursesWithTopic = context.Courses
            //    .Include(c => c.Topic)
            //    .ToList();
            //foreach (var course in coursesWithTopic)
            //{
            //    Console.WriteLine($"{course.Name} - Topic: {course.Topic?.Name}");
            //}

            #endregion

            #region Explicit Loading

            // Example 1: Reference navigation (Student -> Department)
            //var student = context.Students.FirstOrDefault(s => s.ID == 1);
            //if (student != null)
            //{
            //    Console.WriteLine($"Student Name: {student.FName} {student.LName}");
            //    Console.WriteLine($"Department ID: {student.Dep_Id}");

            //    // Explicitly load the Department reference
            //    context.Entry(student).Reference(s => s.Department).Load();
            //    Console.WriteLine($"Department Name: {student.Department?.Name}");
            //}

            // Example 2: Collection navigation (Department -> Students)
            //var department = context.Departments.FirstOrDefault(d => d.ID == 1);
            //if (department != null)
            //{
            //    Console.WriteLine($"Department Name: {department.Name}");

            //    // Explicitly load the Students collection
            //    context.Entry(department).Collection(d => d.Students).Load();

            //    foreach (var stud in department.Students)
            //    {
            //        Console.WriteLine($"Student: {stud.FName} {stud.LName}");
            //    }
            //}

            //// Example 3: Collection navigation with filter (Department -> Students where Age < 30)
            var department2 = context.Departments.FirstOrDefault(d => d.ID == 2);
            if (department2 != null)
            {
                Console.WriteLine($"Department Name: {department2.Name}");

                // Explicitly load filtered Students collection
                context.Entry(department2)
                    .Collection(d => d.Students)
                    .Query()
                    .Where(s => s.Age < 30)
                    .Load();

                foreach (var stud in department2.Students)
                {
                    Console.WriteLine($"Student (Age<30): {stud.FName} {stud.LName}");
                }
            }

            #endregion


        }
    }
}
