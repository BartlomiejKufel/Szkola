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
        public int Money { get; set; }
        public int? DogNumber { get; set; }
        public int Bet { get; set; }

        public Person(string name, int money, int dogNumber, int bet)
        {
            Bet = bet;
            Name = name;
            Money = money;
            DogNumber = dogNumber;
        }


        public void CheckWin(int winerDogNum)
        {
            if (DogNumber == winerDogNum)
            {
                Money += (2 * Bet);
            }
            else
            {
                Money -= Bet;
            }

            Bet = 0;
            DogNumber = 0;
        }
    }
}
