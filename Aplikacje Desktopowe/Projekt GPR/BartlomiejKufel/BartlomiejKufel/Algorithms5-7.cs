using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlomiejKufel
{
    partial class Algorithms
    {
        public static void CaesarCipher()
        {
            Console.Clear();
            string? wordToEncrypt = "";
            do
            {
                Console.WriteLine("Podaj treść do zaszyfrowania");
                wordToEncrypt = Console.ReadLine();

            } while (String.IsNullOrEmpty(wordToEncrypt));

            wordToEncrypt.ToLower();

            Console.WriteLine("Podaj klucz");
            int.TryParse(Console.ReadLine(), out int key);

            string[] alphabet = new string[] { "a", "ą", "b", "c", "ć", "d", "e", "ę", "f", "g", "h", "i", "j", "k", "l", "ł", "m", "n", "ń", "o", "ó", "p", "q", "r", "s", "ś", "t", "u", "v", "w", "x", "y", "z", "ź", "ż" };
            string result="", tmp="";
            
            for (int i = 0; i < wordToEncrypt.Length; i++)
            {
                 tmp = wordToEncrypt[i].ToString();
            }

            Menu.ExitAlgoritm();
        }


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
