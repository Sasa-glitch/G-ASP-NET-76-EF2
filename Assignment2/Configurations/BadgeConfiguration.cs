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
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasOne(e => e.Attendee)
                .WithOne(e => e.Badge)
                .HasForeignKey<Badge>(e => e.AttendeeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
