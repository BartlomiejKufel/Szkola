class Prostopadloscian
{
    //właściwości
    public double Height { get; set; }
    public double Width { get; set; }   
    public double Length { get; set; }

    //konstruktor
    public Prostopadloscian(double h, double w, double l)
    {
        Height = h;
        Width = w;
        Length = l;
    }

    //metoda
    public double Objentosc()
    {
        return Height*Width*Length;
    }
    
    //metoda
    public void Porownanie(double p1, double p2)
    {
        if(p1>p2)
            Console.WriteLine("Prostopadloscian pierwszy jest wiekszy.");
        else
            Console.WriteLine("Prostopadloscian drugi jest wiekszy.");
    }
}


