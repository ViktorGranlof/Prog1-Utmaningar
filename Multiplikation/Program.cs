using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplikationstabell
{

    class Program
    {
        static void Main(string[] args)
        {
            long tal = -1; // Ger tal ett värde
            Console.WriteLine("Multiplikationstabeller");
            Console.Write("Skriv in ett valfritt heltal: ");
            while (tal == -1)
            { // Försöker med att konvertera en string till en int loop i detta fall fungerar den också som felhanterare
                try
                {
                    string userInput = Console.ReadLine(); // Tar in det användaren skriver
                    tal = Convert.ToInt64(userInput); // Fungerar det inte går dn över till exceptions
                    break;
                }
                catch (FormatException) // När formatet inte är korrekt, alltså till exempel en bokstav eller tecken
                {
                    Console.WriteLine("Fel inmatning. Försök igen."); // Skriver ut felmeddelande
                }
                catch (OverflowException) // När talet blir för stort körs det här
                {
                    Console.WriteLine("Fel inmatning. Försök ett lägre nummer."); // Skriver ut felmeddelande
                }
            }
            Console.WriteLine("----------------------------------"); 
            for (int i = 1; i < 11; i++) // Multiplicerar det intagna numret 10 gånger om
            {
                Console.WriteLine(tal + " gånger " + i + " är lika med: " + tal * i); // skriver ut det intagna talet och det som det ska multipliceras med
            }                                                                         // och den riktiga multipliceringen utförs vid "tal * i"
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Tryck valfri knapp för att avsluta programmet.");
            Console.ReadLine(); // Håller programmet öppet
        }
    }
}