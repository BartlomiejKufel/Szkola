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
        public Person TakeMoney(Person per1, Person per2, int money)
        {
            int check = per2.Money - money;
            if (check < 0)
            {
                Console.WriteLine($"{per2.Name} mówi: nie mam wystarczających środków, aby dać ci {money} zł.");
            }
            else if (money == 5)
            {
                per1.Money += money+10;
                per2.Money -= money;
            }
            else
            {
                per1.Money += money;
                per2.Money -= money;
            }

            return per1;
        }
    }
}
