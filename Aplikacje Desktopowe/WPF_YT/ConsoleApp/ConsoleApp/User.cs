using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class User
    {
        public double Portfel { get; set; }


        public User(double portfel)
        {
            Portfel=portfel;
        }

        public void ShowMoney()
        {
            Console.WriteLine($"Gracz ma {Portfel} zł");
        }
    }
}
