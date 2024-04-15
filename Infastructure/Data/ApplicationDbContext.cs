using Domain.Entities;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
        /*
        */
        DbSet<ServiceBooking> ServiceBookings { get; set; }
        DbSet<Service> Services {  get; set; }
        DbSet<ServiceDetails> ServiceDetails { get; set; }
        DbSet<ServiceType> ServiceTypes { get; set; }
        DbSet<ServiceTypeDetails> ServiceTypeDetails { get; set; }
        DbSet<User> Users { get; set; }
        
    }
}