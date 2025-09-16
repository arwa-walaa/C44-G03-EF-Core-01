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

        #region Table Per Concrete Type [TPCT]

        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }


        #endregion
    }
}
