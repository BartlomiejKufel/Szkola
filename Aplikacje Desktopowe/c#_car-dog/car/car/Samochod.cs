using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class Samochod
    {
        protected string marka;
        protected double poj_baku;
        protected int predkosc_max;
        protected double zuzycie_paliwa;

        public Samochod(string marka, double poj_baku, int predkosc_max, double zuzycie_paliwa)
        {
            this.marka = marka;
            this.poj_baku = poj_baku;
            this.predkosc_max = predkosc_max;
            this.zuzycie_paliwa = zuzycie_paliwa;
        }

        public void Jedz(double jakSzybko, double jakDaleko)
        {
            if (jakSzybko > predkosc_max)
            {
                Console.WriteLine("Nie można jechać tak szybko.");
                return;
            }
            
            double ileSpali = (jakDaleko/100) * zuzycie_paliwa;
            double ileTankować = ileSpali/ poj_baku;

            if (ileTankować < 1)
                ileTankować = 0;
            

            Console.WriteLine($"Auto będzie jechało z prędkością {jakSzybko} km/h.");
            
            if(ileTankować == 1)
                Console.WriteLine($"Będzie trzeba tankować {ileTankować} raz.");
            else
                Console.WriteLine($"Będzie trzeba tankować {ileTankować} razy.");

        }
    }

    public class Kabriolet : Samochod
    {
        private bool dach_otwarty;
        public Kabriolet(string marka, double poj_baku, int predkosc_max, double zuzycie_paliwa) : base(marka, poj_baku, predkosc_max, zuzycie_paliwa)
        {
            dach_otwarty = false;
        }


        public bool Dach_otwarty()
        {
            return dach_otwarty = true;
        }

        public bool Dach_zamknięty()
        {
            return dach_otwarty = false;
        }

        public new void Jedz(double jakSzybko, double jakDaleko)
        {
            if (jakSzybko > predkosc_max)
            {
                Console.WriteLine("Nie można jechać tak szybko.");
                return;
            }

            double ileSpali = (jakDaleko / 100) * zuzycie_paliwa;
            if (dach_otwarty)
                ileSpali *= 1.15;

            double ileTankować = ileSpali / poj_baku;

            if (ileTankować < 1)
                ileTankować = 0;


            Console.WriteLine($"Auto będzie jechało z prędkością {jakSzybko} km/h.");

            if (ileTankować == 1)
                Console.WriteLine($"Będzie trzeba tankować {ileTankować} raz.");
            else
                Console.WriteLine($"Będzie trzeba tankować {ileTankować} razy.");

        }

    }
}
