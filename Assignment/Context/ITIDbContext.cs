using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Context
{
    internal class ITIDbContext : DbContext
    {
        public ITIDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ARWA\\SQLEXPRESS01; Database= ITI; Trusted_Connection=True; TrustServerCertificate=True; ");
        }
        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Models.Department> Departments { get; set; }
        public DbSet<Models.Course> Courses { get; set; }
        public DbSet<Models.Instructor> Instructors { get; set; }
        public DbSet<Models.Topic> Topics { get; set; }
        public DbSet<Models.Stud_Course> StudentCourses { get; set; }
        public DbSet<Models.Course_Inst> CourseInstructors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region RelationShops&Data

           
            modelBuilder.Entity<Student>().HasKey(s => s.ID);
            modelBuilder.Entity<Department>().HasKey(d => d.ID);
            modelBuilder.Entity<Course>().HasKey(c => c.ID);
            modelBuilder.Entity<Instructor>().HasKey(i => i.ID);
            modelBuilder.Entity<Topic>().HasKey(t => t.ID);

            // Configure composite keys for junction tables
            modelBuilder.Entity<Stud_Course>().HasKey(sc => new { sc.stud_ID, sc.Course_ID });
            modelBuilder.Entity<Course_Inst>().HasKey(ci => new { ci.inst_ID, ci.Course_ID });


            modelBuilder.Entity<Department>()
            .HasOne(d => d.Instructor)
            .WithOne(i => i.Department) // <-- Use WithOne for one-to-one
            .HasForeignKey<Department>(d => d.Ins_ID)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Instructor>()
              .HasOne(i => i.Department)
              .WithOne(d => d.Instructor) // <-- Use WithOne for one-to-one
              .HasForeignKey<Instructor>(i => i.Dept_ID)
              .OnDelete(DeleteBehavior.NoAction);

            // Student - Department (Many-to-One)
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.Dep_Id);
               


          

            // Course - Topic (Many-to-One)
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.Top_ID);


            // Student - Course (Many-to-Many through Stud_Course)
            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.stud_ID);
               

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.Course_ID)
               ;

            // Instructor - Course (Many-to-Many through Course_Inst)
            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.CourseInstructors)
                .HasForeignKey(ci => ci.inst_ID)
                ;

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInstructors)
                .HasForeignKey(ci => ci.Course_ID)
                ;

            // Configure column properties
            modelBuilder.Entity<Instructor>()
                .Property(i => i.Salary)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Instructor>()
                .Property(i => i.HourRate)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Instructor>()
                .Property(i => i.Bouns)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Stud_Course>()
                .Property(sc => sc.Grade)
                .HasPrecision(5, 2);
            #endregion

            #region Data Migrate Seed

            // Seed Topics
            modelBuilder.Entity<Topic>().HasData(
                new Topic { ID = 101, Name = "Programming (Seed)" },
                new Topic { ID = 102, Name = "Databases (Seed)" }
            );

            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { ID = 101, Name = "Computer Science (Seed)", Ins_ID = 101, HiringDate = new DateTime(2022, 1, 1) },
                new Department { ID = 102, Name = "Information Systems (Seed)", Ins_ID = 102, HiringDate = new DateTime(2023, 1, 1) }
            );

            // Seed Instructors
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { ID = 101, Name = "Carol", Salary = 6000, Address = "111 Seed St", HourRate = 120, Bouns = 600, Dept_ID = 101 },
                new Instructor { ID = 102, Name = "Dave", Salary = 5500, Address = "222 Seed Ave", HourRate = 110, Bouns = 550, Dept_ID = 102 }
            );

            // Seed Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { ID = 101, Name = "EF Core Seed", Description = "Seeded C# Course", Top_ID = 101, Duration = 40 },
                new Course { ID = 102, Name = "SQL Seed", Description = "Seeded SQL Course", Top_ID = 102, Duration = 35 }
            );

            // Seed Students
            modelBuilder.Entity<Student>().HasData(
                new Student { ID = 101, FName = "Mike", LName = "Seedman", Address = "333 Seed Blvd", Age = 23, Dep_Id = 101 },
                new Student { ID = 102, FName = "Sara", LName = "Seeder", Address = "444 Seed Rd", Age = 24, Dep_Id = 102 }
            );

            // Seed Stud_Course (join table)
            modelBuilder.Entity<Stud_Course>().HasData(
                new Stud_Course { stud_ID = 101, Course_ID = 101, Grade = 90 },
                new Stud_Course { stud_ID = 102, Course_ID = 102, Grade = 85 }
            );

            // Seed Course_Inst (join table)
            modelBuilder.Entity<Course_Inst>().HasData(
                new Course_Inst { inst_ID = 101, Course_ID = 101, evaluate = "Seeded Excellent" },
                new Course_Inst { inst_ID = 102, Course_ID = 102, evaluate = "Seeded Good" }
            );

            #endregion
        }

    }
}
