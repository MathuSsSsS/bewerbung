using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202401115_fahrkarten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ticketliste:
            Preisstufe 1 2,90€
            Preisstufe 2 3,70€
            Preisstufe 3 5,10€
            */

            //Preisstufe auswählen
            int Preisstufe = 0;
            double Kosten = 0;


            while (Preisstufe != 1 && Preisstufe != 2 && Preisstufe != 3)
            {
                Console.WriteLine("Gewünschte Tarifstufe eingeben:");
                Console.WriteLine("Preisstufen:");
                Console.WriteLine("Preisstufe 1 2,90€");
                Console.WriteLine("Preisstufe 2 3,70€");
                Console.WriteLine("Preisstufe 3 5,10€");
                Preisstufe = Convert.ToInt32(Console.ReadLine());

                switch (Preisstufe)
                {
                    case 1:
                        Preisstufe = 1;
                        Kosten = 2.90;
                        break;

                    case 2:
                        Preisstufe = 2;
                        Kosten = 3.70;
                        break;

                    case 3:
                        Preisstufe = 3;
                        Kosten = 5.10;
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe.");
                        break;
                }
            }

            //Ermässigungsrabatt abfragen
            string JaNein = "";
            double Kind = 0;

            while (JaNein != "Ja" && JaNein != "Nein")
            {
                Console.WriteLine("Ermässigtes Ticket erwerben? Ja/Nein");
                JaNein = Console.ReadLine();

                if (JaNein == "Ja")
                {
                    Kind = 0.5;
                }

                if (JaNein != "Ja" && JaNein != "Nein")
                {
                    Console.WriteLine("Ungültige Eingabe.");
                }
            }

            //Abfrage Fahrkarte hochstufen
            int upgrade = 0;
            JaNein = "";

            while (JaNein != "Ja" && JaNein != "Nein")
            {
                Console.WriteLine("Vorhandenes Ticket hochstufen? Ja/Nein");
                JaNein = Console.ReadLine();

                switch (JaNein)
                {
                    case "Ja":
                        upgrade = 1;
                        break;

                    case "Nein":
                        upgrade = 0;
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe.");
                        break;
                }
            }

            //falls Fahrkarte vorhanden
            int Vorhandene_Preisstufe;
            double Vorhandene_Preisstufe_Wert = 0;

            while (upgrade == 1)
            {
                Console.WriteLine("Vorhandene Preisstufe eingeben:");
                Vorhandene_Preisstufe = Convert.ToInt32(Console.ReadLine());

                switch (Vorhandene_Preisstufe)
                {
                    case 1:
                        Vorhandene_Preisstufe_Wert = 2.90;
                        upgrade = 2;
                        break;

                    case 2:
                        Vorhandene_Preisstufe_Wert = 3.70;
                        upgrade = 2;
                        break;

                    case 3:
                        Vorhandene_Preisstufe_Wert = 5.10;
                        upgrade = 2;
                        break;

                    default:
                        Console.WriteLine("Ungültige Tarifstufe.");
                        break;
                }
            }

            //Rabatt anwenden
            double Endpreis = 0;

            switch (upgrade)
            {
                case 0:
                    if (Vorhandene_Preisstufe_Wert < Kosten)
                    {
                        Endpreis = Kosten - Vorhandene_Preisstufe_Wert;
                    }
                    else
                    {
                        Console.WriteLine("Vorhandene Preisstufe hochwertiger oder gleichwertig, wie gewünschte Preisstufe");
                    }
                    Endpreis -= Kind;
                    break;

                case 2:
                    if (Vorhandene_Preisstufe_Wert < Kosten)
                    {
                        Endpreis = Kosten - Vorhandene_Preisstufe_Wert;
                    }
                    else
                    {
                        Console.WriteLine("Vorhandene Preisstufe hochwertiger oder gleichwertig, wie gewünschte Preisstufe");
                    }
                    break;

                default:
                    break;
            }
            Console.WriteLine($"Zu zahlen sind: {Endpreis}");
            Console.ReadKey();
        }
    }
}