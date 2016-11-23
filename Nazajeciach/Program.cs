using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nazajeciach
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Aplikacja aplikacja1 = new Aplikacja();
            aplikacja1.WczytajKlawisz();
            Back:
            aplikacja1.WykonajDzialanie();
            goto Back;



            Console.ReadKey();
        }
    }
}
