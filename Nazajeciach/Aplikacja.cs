using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Nazajeciach
{
    class Aplikacja
    {
        private string Klawisz;
        private static Koszyk Zakupy = new Koszyk();
        public void WczytajKlawisz()
        {
            Console.WriteLine("Dzień dobry !");
            Console.WriteLine("Co chcesz zrobic? Nacisnij odpowiedni klawisz.");
            Console.WriteLine("Legenda");
            Console.WriteLine("P - dodaj produkt do koszyka");
            Console.WriteLine("K - skopiuj ostatnio wprowadzony produkt");
            Console.WriteLine("Z - pokaz zawartosc koszyka");
            Console.WriteLine("S - pokaz sume do zaplaty");
            Console.WriteLine("X - skasuj produkt z listy");
            Console.WriteLine("W - wydrukuj paragon");
            Console.WriteLine("N - dodaj nowy koszyk");
            Console.WriteLine("E - zakoncz działanie programu");
        }
        public void WykonajDzialanie()
        {
            Klawisz = Convert.ToString(Console.ReadLine());
            switch(Klawisz)
            {
                case "P":
                    Zakupy.DodajProdukt();
                    break;
                case "K":
                    break;
                case "Z":
                    Zakupy.PokazZawartoscKoszyka();
                    break;
                case "S":
                    Zakupy.ObliczSume();
                    break;
                case "X":
                    Zakupy.UsunZListy();
                    break;
                case "W":
                    Zakupy.WydrukujParagon();
                    break;
                case "N":
                    break;
                case "E":
                    Console.WriteLine("Dziekujemy za skorzystanie z naszych uslug");
                    Thread.Sleep(1000);
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Podałeś nie własciwą wartość");
                    break;

            }
        }
    }
}
