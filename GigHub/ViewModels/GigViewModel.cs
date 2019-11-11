using GigHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace GigHub.ViewModels
{
    public class GigViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Resources.ValidationMessages),
            ErrorMessageResourceName = "RequiredMessage")]
        public string Venue { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.ValidationMessages),
            ErrorMessageResourceName = "RequiredMessage")]
        [ValidTime]
        public string Time { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.ValidationMessages),
            ErrorMessageResourceName = "RequiredMessage")]
        [FutureDate]
        public string Date { set; get; }

        [Required(ErrorMessageResourceType = typeof(Resources.ValidationMessages),
            ErrorMessageResourceName = "RequiredMessage")]
        public byte GenreId { set; get; }

        public IEnumerable<Genre> Genres { set; get; }


        //as Single Responsibility we create method that make parsing of date time because it not belong to controller
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}