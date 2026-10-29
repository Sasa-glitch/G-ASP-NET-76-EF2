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
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        void IEntityTypeConfiguration<Event>.Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasOne(e => e.EventOrganizer)
                .WithMany(e => e.OrganizeEvents)
                .HasForeignKey(e => e.OrganizerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
