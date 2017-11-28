using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meningskonverterare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meningskonverterare");
            bool resultat; // Skapar en Boolean 
            do // "Gör medans"
            {
                resultat = Konverterare();
            }
            while (resultat == false); // Körs medan resultatet är falskt 
        }
        static bool Konverterare()
        {
            Console.WriteLine("Välj 1 för att konvertera till STORA BOKSTÄVER"); // Användaren möts med två val
            Console.WriteLine("Välj 2 för att konvertera till små bokstäver");
            Console.Write("Ditt val: ");
            String mening = Console.ReadLine();
            switch (mening)
            {
                case "1": // Kollar om användaren valde nummer 1

                    break;

                case "2": // Kollar om användare valde nummer 2

                    break;

                default: // Kollar om användaren valde något annat förutom 1 eller 2
                    Console.WriteLine("Fel inmatning");
                    Console.WriteLine("");
                    return false;
            }
            Console.Write("Din mening: ");
            String mening1 = Console.ReadLine(); // Sparar meningen som användaren skriver in

            switch (mening) //Gör en switch sats som antingen gör meningen i Uppercase eller Lowercase
            {
                case "1":
                    mening1 = mening1.ToUpper(); // Gör meningen till uppercase 
                    Console.WriteLine("Konverterad mening: " + mening1);
                    break;

                case "2":
                    mening1 = mening1.ToLower(); // Gör meningen till lowercase 
                    Console.WriteLine("Konverterad mening: " + mening1);
                    break;
            }
            Console.WriteLine("Skriv något för att lämna"); 
            Console.ReadLine(); // Håller programmet öppet tills användare skriver in något mer

            return true; // Kör programmet helt igen returneras true och programmet stängs ner
        }
    }
}
