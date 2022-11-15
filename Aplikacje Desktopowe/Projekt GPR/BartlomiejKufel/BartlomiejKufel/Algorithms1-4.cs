using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlomiejKufel
{
    partial class Algorithms
    {

        //Algorytm 1
        public static void FindBinary()
        {
            Console.Clear();
            
            int[] tab = new int[15] { 1, 23, 3, 14, 0, 200, 4, 27, 5, 10, 3213, 22, 32, 9, 7};
            int tabLength = tab.Length;
            string numberString = "";

            for (int i = 0; i < tabLength; i++)
            {
                numberString += tab[i];
            }

            Menu.DrawArray(numberString, tab);

            Console.WriteLine("\nKtórą liczbę chcesz znaleźć");
            int.TryParse(Console.ReadLine(), out int numberToFind);

            bool result =false;

            for (int i = 0; i < tabLength; i++)
            {
                if (tab[i] == numberToFind)
                {
                    result = true;
                    Console.WriteLine($"\nLiczba znajduje się w {i+1} indeksie.");
                    break;
                }
                
            }

            if (!result) 
                Console.WriteLine("\nLiczba nie znajduje się w tablicy");

            Menu.ExitAlgoritm();
        }




        //Algorytm 2
        public static void FactorialOfNumber()
        {
            Console.Clear();

            int result = 1;
            Console.WriteLine("Podaj liczbę naturalną");
            int.TryParse(Console.ReadLine(), out int primalNumber);

            for (int i = 1; i <= primalNumber; i++)
            {
                result *= i;
            }

            Console.WriteLine($"\nSilnią liczby {primalNumber} jest {result}");

            Menu.ExitAlgoritm();
        }


        //Algorytm 3
        public static void BubbleSort()
        {
            Console.Clear();


            int[] tab = new int[10] { 1, 2, 3, 4, 1, 2, 4, 23, 5, 0};
            int tabLength = tab.Length;
            string numberString = "";

            for (int i = 0; i < tabLength; i++)
            {
                numberString+= tab[i];
            }

            Console.WriteLine("Tablica przed posortowaniem");
            Menu.DrawArray(numberString,tab);

            for (int i = 1; i < tabLength; i++)
            {
                for (int j = 1; j < tabLength; j++)
                {
                    if (tab[j - 1] > tab[j])
                    {
                        int tmp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = tmp;
                    }

                }
            }

            Console.WriteLine("\nTablica po posortowaniu");
            Menu.DrawArray(numberString, tab);

            Menu.ExitAlgoritm();

        }

        //Algorytm 4
        static public void CheckForPalindrome()
        {
            Console.Clear();
            string? wordToCheck = "";
            do
            {
                Console.WriteLine("Podaj słowo do sprawdzenia");
                wordToCheck = Console.ReadLine();
                wordToCheck.Replace(" ", "");

            } while (String.IsNullOrEmpty(wordToCheck));

            wordToCheck.ToLower();
            int wordLength = wordToCheck.Length;
            bool result = false;

            for (int i = 0; i < wordLength / 2; i++)
            {
                if (wordToCheck[i] != wordToCheck[wordLength - i - 1])
                {
                    result = false;
                    break;
                }
                else
                    result= true;
            }

            if (result)
            {
                Console.WriteLine("\nSłowo jest palindromem.");
            }
            else
            {
                Console.WriteLine("\nSłowo nie jest palindromem.");
            }

            Menu.ExitAlgoritm();
        }


    }
}
