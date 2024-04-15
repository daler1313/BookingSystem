using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Data.Configuration
{
    public class ServiceBookingConfiguration: IEntityTypeConfiguration<ServiceBooking>
    {
        public void Configure(EntityTypeBuilder<ServiceBooking> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.BookingNumber)
                .IsRequired();
            builder.Property(s => s.BookingTime)
                .IsRequired();
            builder.Property(s => s.ShceduleTime)
                .IsRequired();
            builder.Property(s => s.BookedPlaceName)
                .IsRequired();
            builder.HasOne(s => s.Users)
                .WithMany(u => u.ServiceBookings)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(s => s.Services)
                .WithMany(se => se.ServiceBookings)
                .HasForeignKey(s => s.ServiceId) .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
