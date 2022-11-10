namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game();
        }



        public static void Game()
        {
            Random rnd=new Random();
            int numberToFind=rnd.Next(1,11);

            while(true)
            {
                Console.WriteLine("Podaj liczbę z zakresu od 1 do 10");
                int tmp = 0;
                int.TryParse(Console.ReadLine(), out tmp);

                if (tmp == numberToFind)
                {
                    break;
                }
                else if(tmp > numberToFind)
                    Console.WriteLine("mniej\n");
                else if(tmp < numberToFind)
                    Console.WriteLine("więcej\n");
            
            }

            Console.WriteLine("Gratulacje");
        }
    }
}