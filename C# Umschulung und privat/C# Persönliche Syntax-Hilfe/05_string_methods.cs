using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240325_C__5_string_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Max Mustermann";
            string telefonnummer = "0521 51823932";

            // alle buchstaben in großbuchstaben umwandeln
            name = name.ToUpper();
            // alle buchstaben in kleinbuchstaben umwandeln
            name = name.ToLower();

            // in einem string bestimmte Zeichen mit einem anderen Zeichen ersetzen
            telefonnummer = telefonnummer.Replace(" ", "/");
            Console.WriteLine(telefonnummer);

            // einem string einen anderen string hinzufügen
            // 0 = Startposition, "Dr. " = hinzuzufügender String
            String NameMitAkGrad = name.Insert(0, "Dr. ");
            Console.WriteLine(NameMitAkGrad);

            // Ausgabe der Länge eines Strings in Ganzzahl
            Console.WriteLine(name.Length);

            // Ausgabe eines bestimmten Zeichens an einer bestimmten Position
            Console.WriteLine(name[2]);

            // Ausgabe eines bestimmten Teils eines Strings
            // Startposition, Anzahl der Zeichen
            Console.WriteLine(name.Substring(4, 5));


            // prüfen, ob ein string mit einem bestimmten string beginnt
            bool startsWith = name.StartsWith("Max");
            // prüfen, ob ein string mit einem bestimmten string endet
            bool endsWith = name.EndsWith("mann");
            // prüfen, ob ein string einen bestimmten string enthält
            bool contains = name.Contains("Muster");
            // prüfen, ob ein string leer ist
            bool isEmpty = string.IsNullOrEmpty(name);
            Console.WriteLine(String.Format("Starts with: {0}, Ends with: {1}, Contains: {2}, Is empty: {3}", startsWith, endsWith, contains, isEmpty));      
            Console.ReadKey();
        }
    }
}
