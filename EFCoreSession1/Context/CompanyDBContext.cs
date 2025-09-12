using EFCoreSession1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession1.Context
{
    internal class CompanyDBContext :DbContext
    {
        //when you create a dbcontext class you need to install the following nuget packages
        //Microsoft.EntityFrameworkCore.SqlServer
       
        public CompanyDBContext(): base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CompanyRoute;Integrated Security=True);
        
        optionsBuilder.UseSqlServer("Server=ARWA\\SQLEXPRESS01; Database= CompanyRoute; Trusted_Connection=True; TrustServerCertificate=True; ");
        }

        #region FluentAPIS
        //apply mapping with configure APIS must override 'onModelCreating'

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region One to One

           
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Models.Employee>()
                .HasOne(e => e.MangeDept)
                .WithOne(e => e.Manager)
                .HasForeignKey<Models.Department>(D=>D.MangerId)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion
            #region OneToMany

        

            //modelBuilder.Entity<Models.Department>()
            //    .HasMany(d => d.Employees)
            //    .WithOne(e => e.EmployeeDepartment)
            //    .HasForeignKey(e => e.EmpDeptId);
               


            #endregion


        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Models.Employee>().HasKey(E=>E.Id);

        //    //modelBuilder.Entity<Models.Employee>().Property(E => E.Id)
        //    //    .UseIdentityColumn(10,10);
        //    ////deny constarin 

        //    //modelBuilder.Entity<Models.Employee>()
        //    //    .Property(E => E.Id)
        //    //    .ValueGeneratedNever();

        //     //modelBuilder.Entity<Models.Employee>()
        //     //    //.Property("Name") may throw exception if property name is wrong
        //     //    .Property(E => E.Name)
        //     //    .HasColumnName("EmployeeName")
        //     //    .HasColumnType("varchar(50)")
        //     //    .HasMaxLength(50)
        //     //    .IsRequired(false);//By default true 

        //    modelBuilder.Entity<Models.Employee>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Name).HasColumnName("EmployeeName")
        //         .HasColumnType("varchar(50)")
        //         .HasMaxLength(50)
        //         .IsRequired(false);
        //        entity.Property(e => e.Salary).HasDefaultValue(8000);

        //    });

        //}

        #endregion

        //if you want a model turned ito table in database 
        //you must use DbSet<T> property
        public DbSet<Models.Employee> Employees { get; set; }

        public DbSet<Models.Department> Departments { get; set; }
        public DbSet<Models.User> UserTable { get; set; }

        //public DbSet<Models.Address> Addresses { get; set; }

    }
}
