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
            bool resultat;
            do
            {
                resultat = StartaKalkylator();      //StartaKalkylator returnerar bool in i resultat
            }
            while (resultat == false);
        }
        static bool StartaKalkylator()  //Använder bool för att tala om om programmet lyckades med beräkningen eller inte
        {                               //Retunerar det false startas det om igen
            Console.WriteLine("Räknesätt:");              //Skapar en meny med olika räknesätt att välja bland
            Console.WriteLine("1: Addition");             
            Console.WriteLine("2: Subtraktion");
            Console.WriteLine("3: Multiplikation");
            Console.Write("Ditt val: ");
            String raknesatt = Console.ReadLine();
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
            Console.Write("Tal 1: ");
            String tal1 = Console.ReadLine();

            Console.Write("Tal 2: ");
            String tal2 = Console.ReadLine();

            int tal1int = 0; //
            int tal2int = 0;
            try
            {
                tal1int = int.Parse(tal1); 
                tal2int = int.Parse(tal2);
            }
            catch(Exception e)
            {
                Console.WriteLine("Fel inmatning!");
                Console.WriteLine(""); //Tom rad för att enklare utläsa kalkylatorn
            }

            int resultatet = 0; 
            switch (raknesatt)
            {
                case "1":
                    resultatet = tal1int + tal2int; //Summan av tal1 och tal2 läggs i resultat och skriver över annan summa som legat där tidigare
                    Console.WriteLine("Summan av " + tal1int.ToString() + " plus " + tal2int.ToString() + " är: " + resultatet.ToString());                                                                                                                       
                    break;  //ToString betyder att man gör om talet till en string

                case "2":
                    resultatet = tal1int - tal2int;
                    Console.WriteLine("Summan av " + tal1int.ToString() + " minus " + tal2int.ToString() + " är: " + resultatet.ToString());
                    break;

                case "3":
                    resultatet = tal1int * tal2int;
                    Console.WriteLine("Summan av " + tal1int.ToString() + " gånger " + tal2int.ToString() + " är: " + resultatet.ToString());
                    break;
            }
            Console.ReadLine(); 
            return true;
        }
    }
}
