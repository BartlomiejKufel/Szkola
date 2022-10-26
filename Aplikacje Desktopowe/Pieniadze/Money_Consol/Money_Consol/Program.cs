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
                int tmp;

                switch (personRequest)
                {
                    case "Bartek":
                        tmp = bartek.GiveMoney(money, bartek);
                        if ( tmp== 0)
                        {
                            Console.WriteLine($"{bartek.Name} mówi: nie mam wystarczająco środków aby dać ci {money} zł.");
                        }
                        else
                        {
                            jacek.TakeMoney(tmp,jacek);
                        };
                        break;
                    case "Jacek":
                        tmp = jacek.GiveMoney(money, jacek);
                        if ( tmp == 0)
                        {
                            Console.WriteLine($"{jacek.Name} mówi: nie mam wystarczająco środków aby dać ci {money} zł.");
                        }
                        else
                        {
                            bartek.TakeMoney(tmp, bartek);
                        } ; break;
                }

            }while (true);
        
            
        }





    }
}