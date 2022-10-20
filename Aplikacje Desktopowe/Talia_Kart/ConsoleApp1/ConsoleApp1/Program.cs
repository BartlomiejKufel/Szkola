namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość tablicy:");
            int tabLength = 0;
            int.TryParse(Console.ReadLine(), out tabLength);
            int[] tab = new int[tabLength];

            Console.WriteLine("Podaj liczby do tablicy");
            for (int i = 0; i < tabLength; i++)
            {
                int.TryParse(Console.ReadLine(), out tab[i]);
            }

            Console.WriteLine($"\nNajmniejsza liczba w tablicy {MinNumber(tab)}");
            Console.WriteLine($"Największa liczba w tablicy {MaxNumber(tab)}");
            Console.WriteLine($"Średnia wylicznona z tablicy {MeanNum(tab)}");
            Console.WriteLine($"Suma liczb pierwszych w tablicy {PrimeNumSum(tab)}");



        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        static int PrimeNumSum(int[] tab)
        {
            int result = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                int tmp=tab[i];
                if (IsPrime(tmp))
                    result+=tmp;
            }

            return result;
        }

        static double MeanNum(int[] tab)
        {
            double result = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                result += tab[i];
            }

            return result/tab.Length;
        }

        static int MinNumber(int[] tab)
        {
            int minNum = 999;

            for (int i = 0; i < tab.Length; i++)
            {
                if (minNum > tab[i])
                    minNum = tab[i];
            }
            return minNum;
        }


        static int MaxNumber(int[] tab)
        {
            int maxNum = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if (maxNum < tab[i])
                    maxNum = tab[i];
            }
            return maxNum;
        }
    }
}