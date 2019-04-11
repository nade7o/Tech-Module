using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesList
{
    class Country
    {
        public string CountryName { get; set; }
        public string Capital { get; set; }
        public string Flag { get; set; }

        public Country(string CountryName, string Capital )
        {
            this.CountryName = CountryName;
            this.Capital = Capital;
        }
    }
}
