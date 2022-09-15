class Punkt
{
    //właściwości
    public int X { get; set; }
    public int Y { get; set; }
    //konstrutor
    public Punkt(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    //metoda
    public void Przesun(int vx, int vy)
    {
        X += vx;
        Y += vy;
    }

    //metoda
    public void Wyswietl()
    {
        Console.WriteLine($"x: {X}; y:{Y}");
    }
}

class Start
{
    static void Main(string[] args)
    {
        //obiekt klasy punkt i wywołanie jego metod
        Punkt pkt = new Punkt(5, 4);
        pkt.Przesun(2, 1);
        pkt.Wyswietl();

        //2 obiekty klasy prostopadloscian
        Prostopadloscian pros1 = new Prostopadloscian(4, 6, 5.5);
        Prostopadloscian pros2 = new Prostopadloscian(5, 10, 12);

        //wywołanie moetody 
        pros1.Porownanie(pros1.Objentosc(), pros2.Objentosc());
    }
}


