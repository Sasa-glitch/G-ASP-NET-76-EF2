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
    internal class OrganizerProfileConfiguration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasOne(e => e.Organizer)
                .WithOne(e => e.Profile)
                .HasForeignKey<OrganizerProfile>(e => e.OrganizerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
