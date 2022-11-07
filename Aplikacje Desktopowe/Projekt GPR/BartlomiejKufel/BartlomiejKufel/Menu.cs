using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlomiejKufel
{
    public class Menu
    {
        public static void StartDialog()
        {
            
        }

        public static void SelectionDialog()
        {
            int option;
            do
            {
                string s1 = "~Algorytmy Klasyczne Aplikacja Zaliczeniowa~";
                Console.WriteLine("\n");
                Console.SetCursorPosition((Console.WindowWidth - s1.Length) / 2, Console.CursorTop);
                Console.WriteLine($"{s1}\n\n\n");

                string s2 = "1. Przeszukiwanie binarne - wersja iteracyjna\n";
                s2 += "2. Obliczanie silni liczby naturalnej\n";
                s2 += "3. Sortowanie bąbelkowe\n";
                s2 += "4. Sprawdzanie czy wyraz jest palindromem\n";
                s2 += "5. Szyfrowanie – szyfr Cezara\n";
                s2 += "6. Wyznaczanie wartości wyrażenia zapisanego w odwrotnej notacji polskiej ONP\n";
                s2 += "7. Jednoczesne znajdowanie minimalnego i maksymalnego elementu.\n";
                s2 += "8. Mnożenie macierzy 2-wymiarowej\n";
                s2 += "9. Transpozycja macierzy 3x3\n";
                s2 += "10. Chwila relaksu\n";
                s2 += "0. Zamknij program\n\n";
                Console.WriteLine(s2);

                Console.WriteLine("Wybierz numer: ");

                Console.Write("> ");
                int.TryParse(Console.ReadLine(), out option);
                Console.WriteLine();

                switch (option)
                {
                    case 1:; break;
                    case 2:; break;
                    case 3:; break;
                    case 4:; break;
                    case 5:; break;
                    case 6:; break;
                    case 9:; break;
                    case 0: break;
                        
                    default: Console.Clear(); break;
                }


            } while (option != 0);

            EndDialog();
        }

        private static void EndDialog()
        {
            Console.Clear();

            Console.WriteLine("\n\n\n");

            string s1 = "APLIKACJA STWORZONA PRZEZ";
            Console.SetCursorPosition((Console.WindowWidth - s1.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{s1}");
            
            s1 = "Bartłomieja Kufla";
            Console.SetCursorPosition((Console.WindowWidth - s1.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{s1}");

            Console.WriteLine("\n\n\n");

        }

    }
}
