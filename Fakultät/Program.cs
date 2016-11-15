using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Summe_einer_Folge
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe;
            BigInteger ergebnis = 1;

            Console.WriteLine("Bitte geben Sie eine Zahl ein");
            if (int.TryParse(Console.ReadLine(),out eingabe) == false) { Console.WriteLine("Sie haben keine gültige Zahl eingegeben!"); Console.Read(); return; }

            //Zusatzfeature
            for (int i = 1; eingabe > 1000 || eingabe < 0; i++)
            {
                Console.WriteLine("Falsche Eingabe! Zahlen zwischen 0 und 60");
                Console.WriteLine("Bitte geben Sie eine Zahl ein");
                if (i >= 3) { Console.WriteLine("Es wurden zu viele falsche Eingaben getätigt!"); Console.ReadLine(); return; }
                int.TryParse(Console.ReadLine(), out eingabe);
            }

            for (int i = 1; i <= eingabe && eingabe != 0; i++)
            {
                ergebnis *= i;
                Console.WriteLine("{0} - ter Schleifendurchgang, Zwichenergebnis: {1}", i, ergebnis);
            }
            Console.WriteLine("Die Fakultät von {0} ist: {1}", eingabe, ergebnis);
            Console.Read();
        }
    }
}
