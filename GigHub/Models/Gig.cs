using System;

namespace GigHub.Models
{
    public class Gig
    {
        public int ID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime DateTime { get; set; }
        public string Venue { get; set; }
        public Genre Genre { get; set; }

    }
}