using System;
using System.Collections.Generic;
using System.Text;

namespace Task14_1_1.Classes
{
    public class City
    {
        public City(string name, long population)
        {
            Name = name;
            Population = population;
        }

        public string Name { get; set; }
        public long Population { get; set; }
    }
}
