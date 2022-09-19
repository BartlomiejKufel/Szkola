
class MyApp
{
    public int[] tab = new int[10];

    public MyApp(int[] tab)
    {
        this.tab = tab;
    }

    /********************************************************
    
    * nazwa funkcji: <SortBySelect>
    * parametry wejściowe: <tab> - <tablica z liczbami całkowitymi>
    * wartość zwracana: <posortowaną tablicę liczb całkowitych>
    * autor: <3456789896>
    
    ******************************************************/

    public int[] SortBySelect(int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            int min = i;

            for (int j = i+1; j < tab.Length; j++)
            {
                if (tab[min] > tab[j])
                    min = j;
            }
            int tmp = tab[min];
            tab[min] = tab[i];
            tab[i] = tmp;
        }

        return tab;
    }


    /********************************************************
    
    * nazwa funkcji: <FindMaxInt>
    * parametry wejściowe: <tab> - <tablica z liczbami całkowitymi>
    * wartość zwracana: <Maksymalną liczbę całkowitą z tablicy>
    * autor: <3456789896>
    
    *****************************************************/

    public int FindMaxInt(int[] tab)
    {
        int result = 0;

        for (int i = 0; i < tab.Length; i++)
        {
            if (result < tab[i])
                result = tab[i];
        }

        return result;
    }


}


class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wpisz 10 elementó do tablicy:");
        int[] userTab = new int[10];
        for (int i = 0; i < userTab.Length; i++)
        {
            userTab[i] = Convert.ToInt32(Console.ReadLine());
        }

        MyApp app = new MyApp(userTab);

        app.SortBySelect(app.tab);
        Console.Write("Posortowana tablica: ");
        foreach (var item in app.tab)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine($"\nMaksymalna wartość w tablicy to: {app.FindMaxInt(app.tab)}");
    }
}