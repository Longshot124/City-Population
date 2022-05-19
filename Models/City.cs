using System;
using System.Collections.Generic;
using System.Text;

namespace Country_City_Population.Models
{
   public class City
    {
        public string Name;
        public int Population;

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public override string ToString()
        {
            return $"Name : {Name} Population : {Population}";
        }
    }
}
