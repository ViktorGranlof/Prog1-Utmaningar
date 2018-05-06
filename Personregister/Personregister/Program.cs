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
            Register registerNamn = new Register();  //Skapar ett register
            Console.WriteLine("Personregister");
            Console.WriteLine();
           
            int klar = 2; //Get variabeln klar ett värde
            do //Om klar == 2 är visaMeny true.
            {
                bool visaMeny = false;
                if(klar == 2)
                {
                    visaMeny = true;
                }
                klar = startaPersonregister(registerNamn, visaMeny);
            }
            while (klar != 0);  //Kör medans klar inte har värdet noll
        }
        static int startaPersonregister(Register registerNamn, bool visaMeny) 
        {
            if (visaMeny) //Boolen visaMeny körs
            {
                Console.WriteLine("Dina val:");                                  //Gör en meny där använder kan välja vad denne vill göra
                Console.WriteLine("Tryck 1 för att se personerna i listan");
                Console.WriteLine("Tryck 2 för att lägga till en person");
                Console.WriteLine("Skriv befintligt namn på en person för att få mer information");
                Console.WriteLine("Skriv \"meny\" för att se menyn igen");
                Console.WriteLine("Tryck 0 för att avsluta");
                Console.WriteLine();
            }
            Console.Write("Ditt val: ");
            String val = Console.ReadLine(); //Tar in det användaren skriver och lägger in det i stringen 'val'
            switch (val) //Använder 'val' i en switch-sats
            {
                case "0": //Är val = 0 så avslutas programmet enligt valen man har i menyn
                    return 0;

                case "1": //Är val = 1 körs det valet i menyn
                    registerNamn.ListPersoner(); //Hämtar listan med personer
                    Console.WriteLine();
                    return 1;

                case "2": //Är val = 2 får användaren lägga till en person
                    try
                    {
                        Console.Write("Namn: ");
                        string name = Console.ReadLine(); //Tar in det namn användaren skrivit
                        Console.Write("Ålder: ");
                        string age = Console.ReadLine();  //Tar in den åldern användare skrivit
                        Console.Write("Stad: ");
                        string location = Console.ReadLine(); //Tar in den plats användaren srkivit
                        registerNamn.addPerson(name, int.Parse(age), location);
                        Console.WriteLine("Person tillagd "); 
                        Console.WriteLine();
                    }
                    catch(Exception e) //Blir det något fel fångas det upp här
                    {
                        Console.WriteLine("Fel inmatning");
                        Console.WriteLine();
                    }
                    return 1;

                default: 
                    if(val == "meny") //Om användaren skrivit in 'meny' körs 
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
