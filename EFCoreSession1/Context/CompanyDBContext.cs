using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        
        optionsBuilder.UseSqlServer("Server=.; Database= CompanyRoute; Trusted_Connection=True; TrustServerCertificate=True; ");
        }

        //if you want a model turned ito table in database 
        //you must use DbSet<T> property
        public DbSet<Models.Employee> Employees { get; set; }
        public DbSet<Models.User> UserTable { get; set; }

    }
}
