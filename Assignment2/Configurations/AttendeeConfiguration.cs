using Assignment2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Configurations
{
    internal class AttendeeConfiguration : IEntityTypeConfiguration<Attendee>
    {
        void IEntityTypeConfiguration<Attendee>.Configure(EntityTypeBuilder<Attendee> builder)
        {
            // Jokes on me he wants it by data annotation
            
            //builder.Property(e => e.FullName).HasMaxLength(150);
            //builder.Property(e => e.Email).HasMaxLength(200);
            //builder.Property(e => e.Street).HasMaxLength(150);
            //builder.Property(e => e.City).HasMaxLength(100);
            //builder.Property(e => e.Country).HasMaxLength(100);
            //builder.Property(e => e.PostalCode).HasMaxLength(20);




        }
    }
}
