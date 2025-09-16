using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertanceMapping.Context
{
    internal class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ARWA\\SQLEXPRESS01; Database= CompanyRoute2; Trusted_Connection=True; TrustServerCertificate=True; ")
             ; 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Table Per Hierarchy [TPH]
            modelBuilder.Entity<FullTimeEmployee>()
                .HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>()
                .HasBaseType<Employee>();

            modelBuilder.Entity<Employee>()
                .HasDiscriminator<string>("EmployeeType")
                .HasValue<FullTimeEmployee>("FTE")
                .HasValue<PartTimeEmployee>("PTE");

            #endregion

        }



        #region 1.Table Per Concrete Type [TPCT]


        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }


        #endregion

        #region 2.Table Per Heirarechy

        public DbSet<Employee> Employees { get; set; }
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }


        #endregion
    }
}
