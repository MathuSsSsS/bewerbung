using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240325_C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datentypen und deren Ausgabe mit Console.Writeline()
            int x;              // Deklaration
            x = 123;            // Initialisierung

            int y = 456;        // Deklaration und Initialisierung

            int z = x + y;      // Operation zweier Werte

            int alter = 30;         // Ganzzahlen (Integer)
            double height = 123.45; // Dezimalzahlen (Double)
            bool alive = false;     // Boolische Zustände (true oder false)
            char symbol = '@';      // Ein einziges Zeichen (Char)
            String name = "Brudi";  // Zeichenkette (String)
            
            //Konstanten verhindern der Veränderung von Werten in einem laufendem Programm
            const double PI = 3.14159265359;

            Console.WriteLine("Hallo " + name);
            Console.WriteLine("Du bist " + alter + "Jahre alt");
            Console.WriteLine("Deine Höhe ist " + height + "cm");
            Console.WriteLine("Bist du am Leben? " + alive);
            Console.WriteLine("Symbol: " + symbol);
            Console.WriteLine("PI: " + PI);

            String benutzername = symbol + name;

            Console.WriteLine("Dein Benutzername ist: " + benutzername);

            //mehrere Variablen in einem String ausgeben
            Console.WriteLine("Name: {0} und dein Alter: {1}", name, alter);



            Console.ReadKey();
        }
    }
}
