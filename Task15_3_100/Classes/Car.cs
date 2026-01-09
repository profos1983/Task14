using System;
using System.Collections.Generic;
using System.Text;

namespace Task15_3_100.Classes
{
    public class Car
    {
        public Car (string manufacturer, string countryCode)
        {
            Manufacturer = manufacturer;
            CountryCode = countryCode;
        }

        public string Manufacturer { get; set; }
        public string CountryCode { get; set; }
    }
}
