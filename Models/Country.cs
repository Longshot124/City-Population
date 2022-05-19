using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Country_City_Population.Models
{
    public class Country
    {
        public string Name;
        public int TotalPopulation;
        public ArrayList Cities;

        
        public Country(string name)
        {
            Name = name;
            Cities = new ArrayList();

        }
        public void Add(City city)
        {
            Cities.Add(city);
        }

        public void SearchAllByPopulation(int min, int max) 
        {

            foreach (City item in Cities)
            {
                if (item.Population>min&&item.Population<max)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void Total() 
        {
            foreach (City city in Cities)
            {
                TotalPopulation += city.Population;
            }
            Console.WriteLine($"\n {Name} has {TotalPopulation} population");
        }
    }
}
