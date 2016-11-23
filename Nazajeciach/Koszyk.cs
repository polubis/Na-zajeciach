using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nazajeciach
{
    class Koszyk
    {
        private List<Produkt> Zakupy;
        public Koszyk()
        {
            Zakupy=new List<Produkt>();
        }
        public void WydrukujParagon()
        {
            string Dzien = DateTime.Now.Day.ToString();
            string Miesiac = DateTime.Now.Month.ToString();
            string Rok = DateTime.Now.Year.ToString();
            string Godzina = DateTime.Now.Hour.ToString();
            string Nazwa = Dzien+Miesiac+Rok+Godzina+".txt";
            if (!File.Exists(Nazwa))
            {
                StreamWriter Faktura = new StreamWriter(Nazwa,true);
                using (Faktura)
                {
                    Faktura.WriteLine("Zakupow dokonano {0}", Nazwa);
                    Faktura.WriteLine("Zaplacono {0}", ObliczSume());
                    foreach (var element in Zakupy)
                    {
                        Faktura.WriteLine("{0} ,{1}, {2}", element.ZwracamNazwe(), element.ZwracamCene(), element.ZwracamIlosc());
                    }
                }
            }
            Zakupy.Clear();

           
        }
        public void DodajProdukt()
        {
            string Nazwa;
            double Cena;
            int Ilosc,Ile;
            Console.WriteLine("Ile razy chcesz skorzystac z tej opcji? [Wartosc 0 cofa do Menu glownego]");
            Ile = Convert.ToInt32(Console.ReadLine());
            if(Ile==0)
            {
                Console.WriteLine("Jestes w Menu glownym");
            }
            else if(Ile>0)
            { 
            Console.WriteLine("Wpisz [Nazwe] produktu, nastepnie [Cene] i [Ilosc]");
            for (int i = 0; i <Ile;i++)
             {

                Console.WriteLine("Wpisz Nazwe");
                Nazwa = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Wpisz Cene");
                Cena = double.Parse(Console.ReadLine());
                Console.WriteLine("Ile chcesz produktow");
                Ilosc = Convert.ToInt32(Console.ReadLine());
                Zakupy.Add(new Produkt(Nazwa,Cena,Ilosc));
                
             }
            
            Console.WriteLine("Jestes w Menu glownym");
            }
            
           
        }
        public void PokazZawartoscKoszyka()
        {
            foreach(var element in Zakupy)
            {
                Console.WriteLine("{0}, {1}, {2}", element.ZwracamNazwe(), element.ZwracamCene(), element.ZwracamIlosc());
            }
        }
        public double ObliczSume()
        {
            double Suma = 0;
            foreach(var element in Zakupy)
            {
                Suma = Suma + element.ZwracamCene() * element.ZwracamIlosc();
            }
            Console.WriteLine("Do zapłaty : {0} zł", Suma);
            return Suma;
        }
        public void UsunZListy()
        {
            Console.WriteLine("Wpisz indeks produktu, ktory chcesz usunac");
            int Indeks = -1;
            Indeks = Convert.ToInt32(Console.ReadLine());
            Zakupy.RemoveAt(Indeks);
        }
        public void DodajNowyKoszyk()
        {
            Zakupy.Clear();
            Zakupy = new List<Produkt>();
        }

    }
}
