using Assignment2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Configurations
{
    internal class OrganizerConfiguration : IEntityTypeConfiguration<Organizer>
    {
        void IEntityTypeConfiguration<Organizer>.Configure(EntityTypeBuilder<Organizer> builder)
        {
            //builder.Property(e => e.Name).HasMaxLength(100);
            //builder.Property(e => e.CompanyName).HasMaxLength(150);
        }
    }
}
