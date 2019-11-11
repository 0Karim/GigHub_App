using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        public int ID { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        public ApplicationUser Artist { set; get; }

        [Required]
        public string ArtistId  { get; set; }
        
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

    }
}