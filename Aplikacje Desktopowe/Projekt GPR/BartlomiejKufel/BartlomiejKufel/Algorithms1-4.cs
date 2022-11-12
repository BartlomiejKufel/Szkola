using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlomiejKufel
{
    partial class Algorithms
    {
        //Algorytm 2
        public static void FactorialOfNumber()
        {
            Console.Clear();

            int primalNumber;
            int result=1;
            Console.WriteLine("Podaj liczbę naturalną");
            int.TryParse(Console.ReadLine(), out primalNumber);

            for (int i = 1; i <= primalNumber; i++)
            {
                result *= i;
            }

            Console.WriteLine($"\nSilnią liczby {primalNumber} jest {result}");

            Menu.ExitAlgoritm();
        }


    }
}
