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

        //jedna metoda na zklejona z 3 innych
        public Person TakeMoney(int money, Person per)
        {
            per.Money += money;
            return per;
        }

        public int GiveMoney(int money, Person per)
        {
            int check = Money - money;
            if (check < 0 || money< 0 )
            {
                return 0;
            }
            else if (CheckForBonus(money))
            {
                per.Money -= money;
                return money + 10;
            }
            else
            {
                per.Money -= money;
                return money;
            }
        }

        public static bool CheckForBonus(int money)
        {
            if (money == 5)
                return true;
            else
                return false;

        }


      
    }
}
