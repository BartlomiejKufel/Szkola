using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Consol
{
    public class Person
    {
        public string? Name;
        public int Money;

        //Wypisz Info
        public void ShowInfo()
        {
            Console.WriteLine($"{Name} ma {Money} zł");
        }

        //Przyjmij Pieniądze

    }
}
