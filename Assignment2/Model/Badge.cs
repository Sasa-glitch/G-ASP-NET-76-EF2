using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Model
{
    internal class Badge
    {
        public int Id { get; set; }
        public string Tier { get; set; }
        public DateTime AttendeeBadge { get; set; }

        public int AttendeeId { get; set; }
        //[ForeignKey(nameof(AttendeeId))]
        public Attendee Attendee { get; set; }

    }
}
