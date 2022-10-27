using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Money
{
    public class Person
    {
        public string? Name;
        public int Money;

        

        public void ShowInfo(Person person1, Person person2)
        {
            MainWindow wnd = (MainWindow)Application.Current.MainWindow;
            wnd.moneyJacekLable.Text = $"{person1.Money} zł";
            wnd.moneyBartekLable.Text = $"{person2.Money} zł";
        }
        public Person TakeMoney(int money, Person per)
        {
            per.Money += money;
            return per;
        }

        public int GiveMoney(int money, Person per)
        {
            int check = Money - money;
            if (check < 0 || money < 0)
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
