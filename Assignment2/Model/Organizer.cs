using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Model
{
    internal class Organizer
    {
        
        public int Id {  get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string CompanyName { get; set; }
        public string VerifiedState { get; set; }
        
        public OrganizerProfile Profile { get; set; }

        public List<Event> OrganizeEvents { get; set; } = new List<Event>();
    }
}
