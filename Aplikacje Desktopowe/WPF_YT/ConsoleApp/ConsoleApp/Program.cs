namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w STS___. Prawdopodobieństwo przegranej: 0,75");
            User user = new User(100);
            Random rnd = new Random();
            
            
            do
            {
                user.ShowMoney();
                Console.Write("Stawiana kwota: ");
                double.TryParse(Console.ReadLine(), out double bet);

                if(bet<=0)
                    Console.WriteLine("Błąd podaj poprawną wartość");
                else if(bet> user.Portfel)
                    Console.WriteLine($"Gracz mówi: nie mam wystarczających środków, aby dać ci {bet} zł");
                else
                {
                    var chance = rnd.NextDouble();

                    if (chance >= 0.75)
                    {
                        Console.WriteLine($"Wygrałeś {bet * 2}");
                        user.Portfel += (bet * 2);
                    }
                    else
                    {
                        Console.WriteLine("Niestety, przegrałeś");
                        user.Portfel -= bet;
                    }

                }
            } while (user.Portfel > 0);

            Console.WriteLine("STS__ zawsze wygrywa");

        }
    }
}