class Sortowanie
{
    public int[] tab = new int[10];

    public Sortowanie(int[] tab)
    {
        this.tab = tab;
    }

    /**********************************************

    *nazwa funkcji:         <SortB>
    *paramaetr wejściowy    <tablica zawierająca int>
    *wartość zwracana       <funkcja zwraca posegregowaną tablicę zawierającą inty>
    *autor                  <34567898763456788>



    ***********************************************/


    public int[] SortB(int[] tab)
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

    public int znajdzMax(int[] tab)
    {
        int result = 0;

        for (int i = 0; i < tab.Length; i++)
        {
            if (result < tab[i])
                result = tab[i];
        }

        return result;
    }
    public int znajdzMin(int[] tab)
    {
        int result = 9999;

        for (int i = 0; i < tab.Length; i++)
        {
            if (result > tab[i])
                result = tab[i];
        }
        return result;
    }

}

class Start
{
    static void Main(string[] args)
    {
        int[] tab = new int[10];
        Console.WriteLine("Wprowadź elementy tablicy:");
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = Convert.ToInt32(Console.ReadLine());
        }

        Sortowanie sort = new Sortowanie(tab);
        sort.SortB(tab);

        foreach (int i in tab)
        {
            Console.Write($"{i}, ");
        }

        Console.WriteLine($"\nNajwiększa liczba w tablicy: {sort.znajdzMax(tab)}");
        Console.WriteLine($"Najminiejsza liczba w tablicy: {sort.znajdzMin(tab)}");


        //Console.WriteLine($"\nNajwiększa liczba w tablicy: {tab.Max()}");
        //Console.WriteLine($"Najminiejsza liczba w tablicy: {tab.Min()}");

    }
}