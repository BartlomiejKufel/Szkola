namespace Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] tab = new int[50];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(1, 100);
            }

            int los=rand.Next(1, 100);
            if (los >=50)
            {
                Console.WriteLine("Metoda sortowania: Sortowanie Bąbelkowe");
                SortB(tab);
            }
            else if (los < 50)
            {
                Console.WriteLine("Metoda sortowania: Sortowanie przez wstawianie");
                SortBySelect(tab);
            }

            foreach (var item in tab)
            {
                Console.Write($"{item}, ");
            }

                
        }

        public static int[] SortB(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length; j++)
                {
                    if (tab[j - 1] > tab[j])
                    {
                        int tmp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = tmp;
                    }

                }
            }
            return tab;
        }


        public static int[] SortBySelect(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                int max = i;

                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[max] < tab[j])
                        max = j;
                }
                int tmp = tab[max];
                tab[max] = tab[i];
                tab[i] = tmp;
            }

            return tab;
        }
    }
}