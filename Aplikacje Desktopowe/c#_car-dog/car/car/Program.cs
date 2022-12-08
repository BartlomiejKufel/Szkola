namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod sm = new Samochod("Mercedes", 62, 220, 6.0);
            sm.Jedz(220, 800);

            Kabriolet kb = new Kabriolet("Cos", 62, 220, 6.0);
           
            kb.Dach_otwarty();
            kb.Jedz(220, 800);

        }
    }
}