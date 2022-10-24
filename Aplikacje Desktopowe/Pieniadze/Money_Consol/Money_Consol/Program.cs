namespace Money_Consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person jacek = new Person() { Name="Jacek", Money=50};
            Person bartek = new Person() { Name = "Bartek", Money = 100 };

            jacek.ShowInfo();
            bartek.ShowInfo();
            var moneyRequest="";
            int money;

            Console.Write("Podaj kwotę: ");
            moneyRequest = Console.ReadLine();

            if (String.IsNullOrEmpty(moneyRequest))
            {
                Environment.Exit(0);   
            }
            else 
            {
                int.TryParse(moneyRequest, out money);
            }

            Console.WriteLine("Pieniądze ma przekazać:");
            var personRequest = Console.ReadLine();

        }




    }
}