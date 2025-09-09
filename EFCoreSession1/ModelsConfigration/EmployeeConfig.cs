using EFCoreSession1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession1.ModelsConfigration
{
    internal class EmployeeConfig : IEntityTypeConfiguration<Models.Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e=>e.Id).UseIdentityColumn(1,1);

            builder.Property(e => e.Name).HasColumnName("EmployeeName")
             .HasColumnType("varchar(50)")
             .HasMaxLength(40)
             .IsRequired(false);
            //one to one [total - total]
            builder.OwnsOne(E=>E.EmpAddress , Address => Address.WithOwner() );

        }
    }
}
