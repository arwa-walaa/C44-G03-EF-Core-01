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
            optionsBuilder.UseSqlServer("Server=ARWA\\SQLEXPRESS01; Database= CompanyRoute; Trusted_Connection=True; TrustServerCertificate=True; ");
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
        }

    }
}
