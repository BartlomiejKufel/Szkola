using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlomiejKufel
{
    partial class Algorithms
    {
        

        //algorytm 8
        public static void Multiplay2DArray()
        {
            Console.Clear();

            int[,] firstArray3x3 = new int[,] { { 2, 2, 3 }, { 4, 5, 0 }, { 1, 2, 1} };
            int[,] secondArray3x3 = new int[,] { { 4, 1, 2 }, { 3, 6, 9 }, { 1, 3, 0} };
            int rowLength = firstArray3x3.GetLength(0);
            int colLength = firstArray3x3.GetLength(1);

            Console.WriteLine("Pierwsza macież 2 wymiarowa");
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write("\n-------------\n");

                for (int j = 0; j < colLength; j++)
                {
                    if (j == colLength-1)
                    {
                        Console.Write(string.Format(" {0} |", firstArray3x3[i, j]));
                    }
                    else if (j == 0)
                    {
                        Console.Write(string.Format("| {0} ", firstArray3x3[i, j]));
                    }
                    else
                    {
                        Console.Write(string.Format("| {0} |", firstArray3x3[i, j]));
                    }
                }
                if (i == rowLength - 1)
                {
                    Console.Write("\n-------------\n");
                }
            }

            int[] resultArray = new int[colLength];
            string numberString = "";


            for (int i = 0; i < colLength; i++)
            {
                int tmp = firstArray3x3[0, i];
                resultArray[i] = tmp * firstArray3x3[1, i];
                numberString += resultArray[i].ToString();

            }

            Console.WriteLine("\nWymnożona macież 2 wymiarowa");


            Menu.DrawArray(numberString, resultArray);
            
            Menu.ExitAlgoritm();
        }


        //algorytm 9
        public static void Transposition3DArray()
        {
            Console.Clear();




            Menu.ExitAlgoritm();
        }


        //algorytm 10
        public static void Game()
        {
            Console.Clear();
            Random rnd = new Random();
            int numberToFind = rnd.Next(1, 11);

            while (true)
            {
                Console.WriteLine("Podaj liczbę z zakresu od 1 do 10");
                int tmp = 0;
                int.TryParse(Console.ReadLine(), out tmp);

                if (tmp == numberToFind)
                {
                    break;
                }
                else if (tmp > numberToFind)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("mniej\n");
                }
                else if (tmp < numberToFind)
                {
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("więcej\n");
                }

                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Gratulacje\n");
            Console.ForegroundColor= ConsoleColor.White;


            Menu.ExitAlgoritm();
        }
    }
}
