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
            optionsBuilder.UseSqlServer("Server=.; Database= CompanyRoute; Trusted_Connection=True; TrustServerCertificate=True; ");
        }
        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Models.Department> Departments { get; set; }
        public DbSet<Models.Course> Courses { get; set; }
        public DbSet<Models.Instructor> Instructors { get; set; }
        public DbSet<Models.Topic> Topics { get; set; }
        public DbSet<Models.Stud_Course> StudentCourses { get; set; }
        public DbSet<Models.Course_Inst> CourseInstructors { get; set; }


    }
}
