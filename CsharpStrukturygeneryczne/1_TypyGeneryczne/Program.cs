using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);
            var wartosc = 0.0;

            while(true)
            {
                var wartoscWejsciowa = Console.ReadLine();
                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
;            }

            Console.WriteLine(" W naszej kolejce");
            while(!kolejka.JestPusty)
            {
                Console.WriteLine("KOlejka " + kolejka.Czytaj());

            }

            Console.ReadKey();
        }
    }
}
