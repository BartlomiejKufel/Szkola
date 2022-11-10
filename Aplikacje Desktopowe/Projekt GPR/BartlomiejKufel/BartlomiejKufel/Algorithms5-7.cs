using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlomiejKufel
{
    partial class Algorithms
    {
        //Algorytm 7
        public static void FindMinAndMax()
        {
            Console.Clear();

            Console.WriteLine("Podaj 10 liczb do tablicy ");
            int[] array = new int[10];
            int arrayLength = array.Length;
            string numberString="";
            int maxNumber = 0;
            int minNumber = 999999999;

            for (int i = 0; i < arrayLength; i++)
            {
                int.TryParse(Console.ReadLine(), out array[i]);
                numberString += array[i].ToString();
                
                if(maxNumber < array[i])
                    maxNumber= array[i];

                if(minNumber > array[i])
                    minNumber= array[i];
            }
            Console.Clear();

            Menu.DrawArray(numberString, array);

            Console.WriteLine($"\nNajmniejsza liczba w tablicy to: {minNumber}");
            Console.WriteLine($"Największa liczba w tablicy to {maxNumber}");

            Menu.ExitAlgoritm();
        }

    }
}
