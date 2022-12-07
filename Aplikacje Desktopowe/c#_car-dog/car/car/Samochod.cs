using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class Samochod
    {
        private string marka;
        private double poj_baku;
        private int predkosc_max;
        private double zuzycie_paliwa;

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
            //zużyte paliwo / trasa * 100
            double ileSpali = jakDaleko/zuzycie_paliwa * 100
            double ileTankować = poj_baku / ileSpali;

            Console.WriteLine($"Auto będzie jechało z prędkością {jakSzybko} km/h.");
            Console.WriteLine($"Będzie trzeba tankować {ileTankować}.");
        }
        


    }
}
