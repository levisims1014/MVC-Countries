using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController cc = new CountryController();
            string[] colors = { "Red", "White", "Blue" };
            Country c = new Country("Stankonia", "Stankonese", "Hello world!", colors);
            cc.CountryDetails(c);
        }
    }
}
