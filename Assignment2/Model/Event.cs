using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Model
{
    [Table("EventOrganizers")]
    internal class Event
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public int MaxNumAllowed { get; set; }
        public int OrganizerId { get; set; }
        [ForeignKey(nameof(OrganizerId))]
        public Organizer EventOrganizer { get; set; }
    }
}
