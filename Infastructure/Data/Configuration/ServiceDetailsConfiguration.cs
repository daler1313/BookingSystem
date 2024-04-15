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
    public class ServiceDetailsConfiguration : IEntityTypeConfiguration<ServiceDetails>
    {
        public void Configure(EntityTypeBuilder<ServiceDetails> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.DetailName)
                .IsRequired();
            builder.Property(s => s.DetailValue)
                .IsRequired();

            
            builder.HasOne(s => s.Services)
                .WithMany(w => w.ServiceDetails)
                .HasForeignKey(s => s.ServiceId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
