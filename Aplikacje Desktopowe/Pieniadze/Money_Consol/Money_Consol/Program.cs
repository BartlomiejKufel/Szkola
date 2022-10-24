namespace Money_Consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person jacek = new Person() { Name="Jacek", Money=50};
            Person bartek = new Person() { Name = "Bartek", Money = 100 };


            do
            {
                jacek.ShowInfo();
                bartek.ShowInfo();
                var moneyRequest="";
                int money=0;

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

                Console.Write("Pieniądze ma przekazać: ");
                var personRequest = Console.ReadLine();

                switch (personRequest)
                {
                    case "Bartek": jacek.TakeMoney(jacek, bartek, money); break;
                    case "Jacek": bartek.TakeMoney(bartek, jacek, money);break;
                }

            }while (true);
        
            
        }





    }
}