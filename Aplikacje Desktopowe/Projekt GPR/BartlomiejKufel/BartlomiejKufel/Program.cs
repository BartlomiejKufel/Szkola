namespace BartlomiejKufel
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Algorytmy Klasyczne Aplikacja Zaliczeniowa";

            await Menu.StartDialog();
            Menu.SelectionDialog();

        }
    }
}