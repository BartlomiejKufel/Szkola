using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LocApp
{
    static class DBlocation
    {
        static public ObservableCollection<Location> locations = new ObservableCollection<Location>()
        { 
            new Location("Kraków", "Polska", 4),
            new Location("Praga", "Czechy", 5)
        };
    }

    public class Location
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
        public string Stars { get; set; }

        public Location(string name, string country, int rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
            Stars = raitingStar();

        }

        public string raitingStar()
        {
            string result = "";
            for (int i = 0; i < Rating; i++)
            {
                result += "⭐";
            }
            return result;
        }
    }
}
