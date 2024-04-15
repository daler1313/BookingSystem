using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Data.Configuration
{
    public class ServiceTypeDetailsConfiquration : IEntityTypeConfiguration<ServiceTypeDetails>
    {
        public void Configure(EntityTypeBuilder<ServiceTypeDetails> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.DetailName)
                .IsRequired();
            builder.Property(d => d.DetailType)
             .IsRequired();     

            builder.HasOne(d =>d .ServiceTypes)
                .WithMany(s => s.ServiceTypeDetails)
                .HasForeignKey(d => d.ServiceTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
