using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHub.Models
{
    public class GigViewModel
    {
        public string Venue { get; set; }
        public string Time { get; set; }
        public string Date { set; get; }
        public int Genre { set; get; }
        public IEnumerable<Genre> Genres { set; get; }
    }
}