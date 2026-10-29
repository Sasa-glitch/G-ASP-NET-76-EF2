using Assignment2.Configurations;
using Assignment2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Contexts
{
    internal class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=EventHub;Trusted_connection=True;TrustServerCertificate=True;");
        }

        DbSet<Organizer> Organizers { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Attendee> Attendee { get; set; }
        DbSet<Badge> Badges { get; set; }
        DbSet<OrganizerProfile> OrganizerProfiles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BadgeConfiguration());
            modelBuilder.ApplyConfiguration(new AttendeeConfiguration());
            modelBuilder.ApplyConfiguration(new OrganizerProfileConfiguration());
        }
    }
}
