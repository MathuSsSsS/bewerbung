using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240325_C_3_Operatoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operatoren:
            // +, -, *, /, %
            // ++, --
            // +=, -=, *=, /=, %=
            /*
            double x = 10;
            double y = 3;

            double a = x + y;
            double b = x - y;
            double c = x * y;
            double d = x / y;
            double e = x % y;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            */

            // -------------------------------------------------------------------- //
            // Block oben oder unten in Kommentar setzen -------------------------- //
            // -------------------------------------------------------------------- //
            
            double x = 3.14;
            double y = 2.71;
            double z = 6.32;

            // Potenz. Hier ist x die Basis und 3 der Exponent
            double a = Math.Pow(x, 3);

            // Quadratwurzel von x
            double b = Math.Sqrt(x);

            // Absolutwert von x (-3 wird zu 3)
            double c = Math.Abs(x);

            // Rundet x auf die nächste ganze Zahl
            double d = Math.Round(x);

            // Rundet x auf die größe ganze Zahl
            double e = Math.Ceiling(x);

            // Rundet x auf die kleinste ganze Zahl
            double f = Math.Floor(x);

            // Gibt den größeren Wert von zwei werten (hier x und y) zurück
            double g = Math.Max(x, y);

            // Gibt den kleineren Wert von zwei werten (hier x und y) zurück
            double h = Math.Min(x, y);



            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            

            Console.ReadKey();
        }
    }
}
