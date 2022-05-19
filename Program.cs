using Country_City_Population.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Country_City_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter country name");
            string ContryName = Console.ReadLine();
            Country country = new Country(ContryName);
            Console.WriteLine("How many cities do you want to include?");
            int count = Convert.ToInt32(Console.ReadLine());
            while (count != 0)
            {
                Console.WriteLine("Enter the city name");
                string cityName = Console.ReadLine();
                Console.WriteLine("Enter the population");
                int population = Convert.ToInt32(Console.ReadLine());
                City city = new City(cityName, population);
                country.Add(city);
                count--;
            }
            Console.WriteLine("Enter the minumum ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum ");
            int max = Convert.ToInt32(Console.ReadLine());
            country.SearchAllByPopulation(min, max);
            country.Total();







        }
    }
}
