using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240325_C__typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type casting: Datentyp in einen anderen umwandeln

            // double auf int
            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(a.GetType());
            Console.WriteLine(a);
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);

            // int auf double
            int c = 123;
            double d = Convert.ToDouble(c);
            Console.WriteLine(c.GetType());
            Console.WriteLine(c);
            Console.WriteLine(d.GetType());
            Console.WriteLine(d);

            // int auf String
            int e = 321;
            String f = Convert.ToString(e);
            Console.WriteLine(e.GetType());
            Console.WriteLine(e);
            Console.WriteLine(f.GetType());
            Console.WriteLine(f);

            // String auf Char
            String g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(g.GetType());
            Console.WriteLine(g);
            Console.WriteLine(h.GetType());
            Console.WriteLine(h);

            String i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(i.GetType());
            Console.WriteLine(i);
            Console.WriteLine(j.GetType());
            Console.WriteLine(j);


            Console.ReadKey();
        }
    }
}
