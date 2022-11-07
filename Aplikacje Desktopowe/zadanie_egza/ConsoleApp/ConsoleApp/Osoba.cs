using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Osoba
    {
        private int id;
        private string? imie;


        public static int count = 0;

        public Osoba()
        {
            id = 0;
            imie = string.Empty;
            count++;
        }

        public Osoba(int id, string? imie)
        {
            this.id = id;
            this.imie = imie;
            count++;
        }

        public Osoba(Osoba ostatniaOsoba)
        {
            id = ostatniaOsoba.id;
            imie = ostatniaOsoba.imie;
            count++;
        }


        public void Pozdrowienie(string? imieOsoby)
        {
            if(imieOsoby.Trim()!=string.Empty)
                Console.WriteLine($"Cześć {imieOsoby}, mam na imię {imie}");
            else
                Console.WriteLine($"Cześć Brak danych, mam na imię {imie}");
        }


    }
}
