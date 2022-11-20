using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BartlomiejKufel
{
    partial class Algorithms
    {
        //algorytm 5
        public static void CaesarCipher()
        {
            Console.Clear();
            string? wordToEncrypt = "";
            do
            {
                Console.WriteLine("Podaj treść do zaszyfrowania");
                wordToEncrypt = Console.ReadLine();

            } while (String.IsNullOrEmpty(wordToEncrypt));


            wordToEncrypt = wordToEncrypt.ToUpper();

            Console.WriteLine("\nPodaj klucz");
            int.TryParse(Console.ReadLine(), out int key);

            string alphabet = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPQRSŚTUVWXYZŹŻ";
            string result="";



            for (int i = 0; i < wordToEncrypt.Length; i++)
            {
                if (char.IsUpper(wordToEncrypt[i]))
                {
                    int charOrginalPosition = alphabet.IndexOf(wordToEncrypt[i]);
                    int charEncryptPosition = (charOrginalPosition + key) % 35 ;
                    result += alphabet[charEncryptPosition];
                }
                else
                {
                    result += wordToEncrypt[i];
                }
            }


            Console.WriteLine($"\nTreść po zaszyfrowaniu: \n{result}");

            Menu.ExitAlgoritm();
        }

        //algorytm 6 - Indonesia Notation 
        public static void ReversePolishNotation() 
        {
            Console.Clear();
            string? equation = "";
            do
            {
                Console.WriteLine("Podaj rónanie zapisane w ONP");
                equation = Console.ReadLine();

            } while (String.IsNullOrEmpty(equation));

            equation = equation.TrimEnd().TrimStart();

            Stack<int> stack = new Stack<int>();
            string tmp="";
            bool error = false;
            int equLen = equation.Length;

            if(equation[equLen - 1] != '+' && equation[equLen - 1] != '-' && equation[equLen - 1] != '*' && equation[equLen - 1] != '/')
            {
                Console.WriteLine("\nWystąpił błąd w zapisie");
                error = true;
            }
            else
            {
                for (int i = 0; i < equLen; i++)
                {
                    char c = equation[i];

                    if (stack.Count > 2)
                    {
                        Console.WriteLine("\nWystąpił błąd w zapisie");
                        error = true;
                        break;
                    }
                    else if (char.IsDigit(c))
                    {
                        tmp += c;
                    }
                    else if (char.IsWhiteSpace(c))
                    {
                        if (String.IsNullOrEmpty(tmp))
                            continue;
                        else
                            stack.Push(int.Parse(tmp));
                        tmp = "";
                    }
                    else if (c == '*' || c == '+' || c == '-' || c == '/')
                    {
                        int result = 0;
                        switch (c)
                        {
                            case '+':
                                while (stack.Count > 0)
                                    result += stack.Pop(); break;

                            case '-':
                                int utmp = stack.Pop();
                                result = stack.Pop() - utmp; break;
                            
                            case '*':
                                result = 1;
                                while (stack.Count > 0)
                                    result *= stack.Pop(); break;
                            
                            case '/':
                                int dtmp = stack.Pop();
                                if(dtmp == 0)
                                {
                                    Console.WriteLine("\nNie można dzielić przez 0");
                                    error = true;
                                }
                                else
                                    result = stack.Pop() / dtmp; break;

                            default:
                                break;
                        }

                        stack.Push(result);

                    }
                    else
                    {
                        Console.WriteLine("\nWystąpił błąd!");
                        error = true;
                        break;
                    }

                }
            }


            if(error == false)
                Console.WriteLine($"\nWynik: {stack.Pop()}");


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
