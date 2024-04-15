﻿using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           builder.HasKey(u => u.Id);
            builder.Property(u => u.UserName)
                 .IsRequired();
            builder.Property(u => u.Name)
                .IsRequired();
            builder.Property(u => u.PhoneNumber)
                .IsRequired();
            builder.Property(u => u.EmaiAddress)
                .IsRequired();
        }
    }
}
