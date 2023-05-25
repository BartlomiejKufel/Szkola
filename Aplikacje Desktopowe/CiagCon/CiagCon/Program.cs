namespace CiagCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj długość tablicy A: ");
            int.TryParse(Console.ReadLine(), out int aLeng);

            int[] A = new int[aLeng];


            Console.WriteLine();

            for (int i = 0; i < aLeng; i++)
            {
                Console.Write($"Podaj wartość dla indexu {i}: ");
                int.TryParse(Console.ReadLine(), out A[i]);
            }

            int count=0, tmp;
            for (int i = 0; i < aLeng; i++)
            {
                if (i == 0)
                {
                    count+=2;
                    continue;
                }

                tmp = A[i-1];
                if(tmp != A[i]){
                    count += 2;
                }
                
            }

            Console.WriteLine($"\nDługość opisu ciągu A: {count}");
        }
    }
}