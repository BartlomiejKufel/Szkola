namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.count} \n");

            Osoba osoba1 = new Osoba();

            Console.WriteLine("Podaj parametry dla nowej osoby");
            
            int id;
            Console.WriteLine("Id:");
            int.TryParse(Console.ReadLine(), out id);

            Console.WriteLine("Imię:");
            string? imie = Console.ReadLine().Trim();

            
            Osoba osoba2 = new Osoba(id, imie);
            Osoba osoba3 = new Osoba(osoba2);
            
            Console.WriteLine();
            
            
            osoba1.Pozdrowienie("Jan");
            osoba2.Pozdrowienie("Jan");
            osoba3.Pozdrowienie("Jan");


            Console.WriteLine($"\nLiczba zarejestrowanych osób to {Osoba.count}");


        }
    }
}