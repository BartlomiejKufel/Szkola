namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] tab = new int[50];
            FillArray(tab, 1, 100);


            int numToFind;
            Console.WriteLine("Podaj liczbe z zakresu od 1 do 100, którą chcesz znaleźć");
            int.TryParse(Console.ReadLine(), out numToFind);


            int result = FindIntIndex(tab, numToFind);
            if (result!=0)
                Console.WriteLine($"Index liczby szukanej: {result}");
            else
                Console.WriteLine("Nie znalezion liczby w tablicy");

            foreach (var item in tab)
            {
                Console.Write($"{item}, ");
            }
        }
        /******************************************************
        nazwa funkcji: <FillArray>
        argumenty:  <tab> - <tablicę licz całkowitych>
                    <minInt> - <minimalną liczbę do zakresu liczb losowych>
                    <maxInt> - <maxymalną liczbę do zakresu liczb losowych>
        typ zwracany: <tab>, <tablica typu int>
        informacje: <Metoda wypełnia tablicę liczbami losowymi z zakresu minInt do MaxInt>
        autor: <Bartłomiej Kufel>
        *****************************************************/
        public static int[] FillArray(int[] tab, int minInt, int maxInt)
        {
            Random random = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = random.Next(minInt, maxInt);
            }
            return tab;
        }

        /******************************************************
        nazwa funkcji: <FindIntIndex>
        argumenty:  <tab> - <tablicę licz całkowitych>
                    <findX> - <liczba szukana>
        typ zwracany: <int>, <index liczby szukanej>
        informacje: <Metoda zwraca index liczby szukanej>
        autor: <Bartłomiej Kufel>
        *****************************************************/

        public static int FindIntIndex(int[] tab, int findX)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                if (findX == tab[i])
                {
                    return i+1;
                }

            }


            return 0;
        }


    }
}