using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GigHub.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;

            var isValid = DateTime.TryParseExact(value.ToString(), "d' 'MMM' 'yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dateTime);

            return (isValid && dateTime > DateTime.Now);
        }
    }

}