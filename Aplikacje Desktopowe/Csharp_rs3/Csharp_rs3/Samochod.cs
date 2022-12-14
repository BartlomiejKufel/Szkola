using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_rs3
{
    public class Samochod
    {
        private static int liczbaSamochodow = 0;
        
        public string Marka { get; set; }
        public string Model { get; set; }
        public int IloscDrzwi { get; set; }
        public int PojemnoscSilnika { get; set; }
        public double SrednieSpalanie { get; set; }

        public Samochod()
        {
            Marka = "nieznana";
            Model = "nieznany";
            IloscDrzwi = 0;
            PojemnoscSilnika = 0;
            SrednieSpalanie = 0.0;

            liczbaSamochodow++;
        }

        public Samochod(string marka, string model, int iloscDrzwi, int pojemnoscSilnika, double srednieSpalanie)
        {
            Marka = marka;
            Model = model;
            IloscDrzwi = iloscDrzwi;
            PojemnoscSilnika = pojemnoscSilnika;
            SrednieSpalanie = srednieSpalanie;

            liczbaSamochodow++;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (SrednieSpalanie * dlugoscTrasy) / 100.0;
        } 

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }


        public void WypiszInfo()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Ilość drzwi: {IloscDrzwi}");
            Console.WriteLine($"Pojemność silnika: {PojemnoscSilnika}");
            Console.WriteLine($"Średnie spalanie: {SrednieSpalanie}\n");
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine($"Jest {liczbaSamochodow} aut.");
        }
    }
}
