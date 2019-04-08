using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public const string DATE_FORMAT = "dd/MM/yyyy";
        public override bool IsValid(object value)
        {            
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), DATE_FORMAT,
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}