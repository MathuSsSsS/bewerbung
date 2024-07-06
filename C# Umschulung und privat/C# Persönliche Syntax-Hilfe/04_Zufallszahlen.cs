using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240325_C__4_Zufallszahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zufallszahlengenerator erstellen (mit einer neuen Instanz von Random)
            Random random = new Random();

            // Zufallszahl zwischen 1 und 20 (exklusiv 21)
            int D20 = random.Next(1, 21);
            int D12 = random.Next(1, 13);
            int D6 = random.Next(1, 7);

            Console.WriteLine("Zufallszahl: " + D20);
            Console.WriteLine("Zufallszahl: " + D12);
            Console.WriteLine("Zufallszahl: " + D6);

            Console.ReadKey();
        }
    }
}
