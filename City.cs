using System;

namespace LB6
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }
        public City(string name, string country, int population, double area)
        {
            Name = name;
            Country = country;
            Population = population;
            Area = area;
        }
        public City() { 
        
        }
        public void PrintCityInfo()
        {
            Console.WriteLine($"City: {Name}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Population: {Population}");
            Console.WriteLine($"Area: {Area} square kilometers");
        }

        public static City operator +(City left, int right)
        {
            return new City { Population = left.Population + right };
        }

        public static City operator -(City left, int right)
        {
            return new City { Population = left.Population - right };
        }

        public static bool operator !=(City left, City right)
        {
            return left.Population != right.Population;
        }

        public static bool operator ==(City left, City right)
        {
            return left.Population == right.Population;
        }

        public static bool operator >(City left, City right)
        {
            return left.Population > right.Population;
        }

        public static bool operator <(City left, City right)
        {
            return left.Population < right.Population;
        }

    }
}

