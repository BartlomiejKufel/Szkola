using System.Security.Cryptography;

namespace LiderKonsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablica:");
            Console.WriteLine("Podaj długość tablicy");
            int arrLength;
            int.TryParse(Console.ReadLine(), out arrLength);
            int[] tab = GenerateArray(arrLength);
            
            Console.WriteLine();

            foreach (var item in tab.Select((value, i)=>new { i,value}))
            {
                var index = item.i + 1; 
                Console.WriteLine($"Pozycja:{index}-{item.value}");
            }
            Console.WriteLine($"Liderem jest: {FindLeader(tab)}");



        }


        public static int[] GenerateArray(int count)
        {
            int[] tab = new int[count];

            Random rand = new Random();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(1, 4);
            }

            return tab;
        }

        public static int FindLeader(int[] tab)
        {
            var half = (tab.Length-1)/2;

            int leader = 0;
            int leaderCount = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                leader = tab[i];
                for (int j = i+1; j < tab.Length; j++)
                {
                    if (leader == tab[j])
                        leaderCount++;
                }

                if (leaderCount >= half)
                {
                    return leader;
                }
                else
                {
                    leaderCount = 0;
                    leader = 0;
                }
            }


            return leader;
        }

    }
}