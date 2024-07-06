using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240325_C__6_if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if statements, if-else statements

            //  if (bedingung)           z.B. (zahl > 10)
            //  {
            //      // code block 1
            //  }
            //  else                     Nur falls ein anderer Fall eintritt und codeblock 2 ausgeführt werden soll
            //  {
            //      // code block 2
            //  }
            
            // logische Operatoren:
            //  ==  Gleich
            //  !=  Ungleich
            //  >   Größer
            //  <   Kleiner
            //  >=  Größer oder gleich
            //  <=  Kleiner oder gleich
            //  &&  Und
            //  ||  Oder
            //  !   Nicht
            //  ^   Exklusives Oder

            Console.WriteLine("Gebe deinen Namen ein: ");
            String name = Console.ReadLine();

            if (name != "")
            {
                Console.Write("Dein Name: " + name);
            }
            else
            {
                Console.WriteLine("Keine Name angegeben");
            }

            Console.ReadKey();

            // #############################################################

            Console.WriteLine("Welchen Wochentag haben wir heute?");
            Console.WriteLine("Gültige Eingaben: Montag, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag");
            String wochentag = Console.ReadLine();

            switch(wochentag)
            {
                case "Montag":
                    Console.WriteLine("Heute ist Montag");
                    break;
                case "Dienstag":
                    Console.WriteLine("Heute ist Dienstag");
                    break;
                case "Mittwoch":
                    Console.WriteLine("Heute ist Mittwoch");
                    break;
                case "Donnerstag":
                    Console.WriteLine("Heute ist Donnerstag");
                    break;
                case "Freitag":
                    Console.WriteLine("Heute ist Freitag");
                    break;
                case "Samstag":
                    Console.WriteLine("Heute ist Samstag");
                    break;
                case "Sonntag":
                    Console.WriteLine("Heute ist Sonntag");
                    break;
                default:
                    Console.WriteLine("Kein gültiger Wochentag");
                    break;
            }   

            Console.ReadKey();

        }
    }
}
