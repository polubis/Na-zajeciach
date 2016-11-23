using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nazajeciach
{
    class Produkt
    {
        private string Nazwa;
        private double CenaJednostkowa;
        private int Ilosc;
        public Produkt() { }
        public Produkt(string Nazwa,double CenaJednostkowa,int Ilosc)
        {
            this.Nazwa = Nazwa;
            this.CenaJednostkowa = CenaJednostkowa;
            this.Ilosc = Ilosc;
        }
        public string ZwracamNazwe()
        {
            return Nazwa;
        }
        public double ZwracamCene()
        {
            return CenaJednostkowa;
        }
        public int ZwracamIlosc()
        {
            return Ilosc;
        }
        public void WypisujePola()
        {
            Console.WriteLine("{0}, {1}, {2}",Nazwa,CenaJednostkowa,Ilosc);
        }
       
    }
}
