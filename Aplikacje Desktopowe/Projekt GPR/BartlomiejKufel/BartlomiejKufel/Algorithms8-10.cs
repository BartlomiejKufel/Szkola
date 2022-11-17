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

            Console.WriteLine("Pierwsza macież");
            Menu.DrawArray3x3(firstArray3x3);

            Console.WriteLine("Druga macież");
            Menu.DrawArray3x3(secondArray3x3);

            int[,] resultArray = new int[rowLength,colLength];

            
            int tmp = 0;

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    
                    tmp = 0;
                    for (int k = 0; k < colLength; k++)
                    {
                        tmp += firstArray3x3[i, k] * secondArray3x3[k, j];
                    }
                    resultArray[i, j] = tmp;
                }
            }

            Console.WriteLine("\nWymnożona macież");
            Menu.DrawArray3x3(resultArray);

            
            Menu.ExitAlgoritm();
        }


        //algorytm 9
        public static void Transposition3DArray()
        {
            Console.Clear();

            int[,] array3x3 = new int[,] { { 2, 2, 3 }, { 4, 5, 0 }, { 1, 2, 1 } };
            int rowLength = array3x3.GetLength(0);
            int colLength = array3x3.GetLength(1);


            Console.WriteLine("Macież przed transpozycją");
            Menu.DrawArray3x3(array3x3);

            int[,] resultArray = new int[colLength, rowLength];

            
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    resultArray[i, j] = array3x3[j, i];
                }
            }

            Console.WriteLine("Macież po transpozycji");
            Menu.DrawArray3x3(resultArray);


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
