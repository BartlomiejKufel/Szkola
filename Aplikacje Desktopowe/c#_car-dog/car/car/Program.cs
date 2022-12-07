namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod sm = new Samochod("Mercedes", 650, 220, 6.0);
            sm.Jedz(220, 40);
            
        }
    }
}