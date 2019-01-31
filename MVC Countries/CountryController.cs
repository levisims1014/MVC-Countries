using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    class CountryController
    {
        public void CountryDetails(Country c)
        {
            CountryDetails cd = new CountryDetails(c);
            cd.Display();
        }

        public void CountryMenu()
        {
            Console.WriteLine("What Continent Would you like to learn about?");
            string input = Console.ReadLine();
            List<Country> countries;
            if (input.ToLower() == "north america")
            {
                NorthAmericaDB nadb = new NorthAmericaDB();
                countries = nadb.Countries;
            }
        }
    }
}