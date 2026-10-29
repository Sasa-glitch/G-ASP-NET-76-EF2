using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Assignment2.Model
{
    internal class Attendee
    {
//        Required: the organizer name, and the attendee full name, email, street, city, country
//and postal code.The company name is optional.
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string FullName { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(150)]
        public string Street { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(100)]
        public string Country { get; set; }
        [MaxLength(20)]
        [Column("ZipCode")]
        public string PostalCode { get; set; }

        [NotMapped]
        public string FullAddress => $"{Street} St, {City}, {Country}";

        public Badge Badge {  get; set; }
    }
}
