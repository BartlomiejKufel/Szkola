using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogs
{
    internal class Person
    {
        public string Name { get; set; }
        public int money { get; set; }
        public int DogNumber { get; set; }
        public int Bet { get; set; }

        public Person(string name, int money, int dogNumber, int bet)
        {
            Bet = bet;
            Name = name;
            this.money = money;
            this.DogNumber = dogNumber;
        }
    }
}
