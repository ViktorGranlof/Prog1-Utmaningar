using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simpel Kalkylator");
            Console.WriteLine("Välj vilket räknesätt du vill använda");
            bool resultat; //Skapar en bool
            do             //Resultat = StartaKalkylator medans resultat är false
            {
                resultat = StartaKalkylator();      //StartaKalkylator returnerar bool in i resultat
            }
            while (resultat == false);
        }
        static bool StartaKalkylator()        //Använder bool för att tala om om programmet lyckades med beräkningen eller inte
        {                                     //Retunerar det false startas det om igen
            Console.WriteLine("Räknesätt:");              //Skapar en meny med olika räknesätt att välja bland
            Console.WriteLine("1: Addition");             
            Console.WriteLine("2: Subtraktion");
            Console.WriteLine("3: Multiplikation");
            Console.Write("Ditt val: ");
            String raknesatt = Console.ReadLine();  //Väntar på att användaren ska skriva in 
            switch (raknesatt)
            {
                case "1":

                    break;

                case "2":         //Koden känner efter vilket tal du skrivit in

                    break;

                case "3":

                    break;

                default:
                    Console.WriteLine("Fel inmatning!");
                    Console.WriteLine(""); //Tom rad för att enklare utläsa kalkylatorn
                    return false;
            }
            Console.Write("Tal 1: ");          //Användaren skriver in ett tal 
            String tal1 = Console.ReadLine();  //Det användaren valt att skriva in sparas i tal1

            Console.Write("Tal 2: ");          //Användaren skriver in ett tal 
            String tal2 = Console.ReadLine();  //Det användaren valt att skriva in sparas i tal2

            int tal1int = 0; //Skapar variabler
            int tal2int = 0;
            try
            {
                tal1int = int.Parse(tal1);  //Försöker att konvertera string-talet till sin motsvariga integer 
                tal2int = int.Parse(tal2);
            }
            catch(Exception e)              //Fångar upp "undantag" som kan ske när int.Parse körs. 'e' står för generella undantag 
            {
                Console.WriteLine("Fel inmatning!");  //Felmeddelande
                Console.WriteLine(""); //Tom rad för att enklare utläsa kalkylatorn
                return false;          //Returnerar false och kör därför om "static bool StartaKalkylator;"
            }

            int resultatet = 0; //Ger variabeln resultatet ett värde
            switch (raknesatt)  //Switch-sats som antingen adderar, subtraherar eller multiplicerar beroende på vilket case some valts
            {
                case "1":
                    resultatet = tal1int + tal2int; //Summan av tal1 och tal2 läggs i resultat och skriver över annan summa som legat där tidigare
                    Console.WriteLine("Summan av " + tal1int.ToString() + " plus " + tal2int.ToString() + " är: " + resultatet.ToString());                                                                                                                       
                    break;  //ToString betyder att man gör om talet till en string

                case "2":
                    resultatet = tal1int - tal2int;//Subtraherar tal1 med tal2 och sätter resultatet till det tal som blir
                    Console.WriteLine("Summan av " + tal1int.ToString() + " minus " + tal2int.ToString() + " är: " + resultatet.ToString());
                    break;

                case "3":
                    resultatet = tal1int * tal2int; //Multiplicerar tal1 med tal2 och sätter resultatet till det tal som blir
                    Console.WriteLine("Summan av " + tal1int.ToString() + " gånger " + tal2int.ToString() + " är: " + resultatet.ToString());
                    break;
            }
            Console.ReadLine(); //Väntar på user input
            return true;        //När något tagits in på ovanstående rad hoppar koden ner hit och returnerar true som stänger ner programmet 
        }
    }
}
