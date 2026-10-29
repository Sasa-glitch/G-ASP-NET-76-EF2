using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Model
{
    internal class OrganizerProfile
    {
        int Id { get; set; }
        public string? Bio { get; set; }
        public string? Website { get; set; }
        public String? LogoLink { get; set; }

        public int OrganizerId { get; set; }
        [ForeignKey(nameof(OrganizerProfile.Id))]
        public Organizer Organizer { get; set; }
    }
}
