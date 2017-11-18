using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Register registerNamn = new Register();
            Console.WriteLine("Personregister");
            Console.WriteLine();
           
            int klar = 2;
            do
            {
                bool visaMeny = false;
                if(klar == 2)
                {
                    visaMeny = true;
                }
                klar = startaPersonregister(registerNamn, visaMeny);
            }
            while (klar != 0);     
        }
        static int startaPersonregister(Register registerNamn, bool visaMeny)
        {
            if (visaMeny)
            {
                Console.WriteLine("Dina val:");
                Console.WriteLine("Tryck 1 för att se personerna i listan");
                Console.WriteLine("Tryck 2 för att lägga till en person");
                Console.WriteLine("Skriv befintligt namn på en person för att få mer information");
                Console.WriteLine("Skriv \"meny\" för att se menyn igen");
                Console.WriteLine("Tryck 0 för att avsluta");
                Console.WriteLine();
            }
            Console.Write("Ditt val: ");
            String val = Console.ReadLine();
            switch (val)
            {
                case "0":
                    return 0;

                case "1":
                    registerNamn.ListPersoner();
                    Console.WriteLine();
                    return 1;

                case "2":
                    try
                    {
                        Console.Write("Namn: ");
                        string name = Console.ReadLine();
                        Console.Write("Ålder: ");
                        string age = Console.ReadLine();
                        Console.Write("Stad: ");
                        string location = Console.ReadLine();
                        registerNamn.addPerson(name, int.Parse(age), location);
                        Console.WriteLine("Person tillagd ");
                        Console.WriteLine();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Fel inmatning");
                        Console.WriteLine();
                    }
                    return 1;

                default:
                    if(val == "meny")
                    {
                        Console.WriteLine();
                        return 2;
                    }
                    else
                    {
                        registerNamn.WritePerson(val);
                        Console.WriteLine();
                        return 1;
                    }
            }
        }
    }
}
