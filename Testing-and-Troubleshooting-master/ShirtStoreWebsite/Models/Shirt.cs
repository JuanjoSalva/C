using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShirtStoreWebsite.Models
{
    public class Shirt
    {
        public int Id { get; set; }
        [Display(Name = "Size"), Required]
        public ShirtSize Size { get; set; }
        [Display(Name = "Color"), Required]
        public ShirtColor Color { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public float Tax { get; set; }

        public string GetFormattedTaxedPrice()
        {
            //ToString("C") method format specifier "C" or "c" name is currency.This format specifier return a currency value. 
            //We can also use a precision specifier to specify number of decimal digit such as ToString("C2").
            //This ToString("C2") method format a numeric value to its equivalent string representation with currency sign and two decimal digits. 
            //So, if we set the method as ToString("C0") then the method format the numeric value with currency sign and without any decimal digit. 
            //It round the decimal number to its nearest integer equivalent.

            //return Price.ToString($"C2", CultureInfo.GetCultureInfo("en-US"));

            return (Price * Tax).ToString($"C2", CultureInfo.GetCultureInfo("en-US"));
        }
    }
}
