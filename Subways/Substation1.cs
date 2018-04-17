using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Substation1
    {
        public int GetChoice()
        {
            Console.WriteLine("Speakers: Welcome to Subwaystation \"One\"");

            do
            {
                Console.Write("Board the train? y/n: ");
                string val = Console.ReadLine();
                if (val == "y")
                {
                    // Åk till Substation 2
                    Console.WriteLine("You are now leaving Subwaystation \"One\".");
                    Console.WriteLine("Press enter to continue..");
                    Console.ReadLine();
                    return 2;
                }
                else if (val == "n")
                {
                    // Tar inte tåget, avslutar
                    Console.WriteLine("You left at Subwaystation \"One\"");
                    Console.ReadLine();
                    return 0;
                }
                else
                {
                    // Fel input leder till felmeddelande och frågar igen
                    Console.WriteLine("Invalid input, try again. ");
                }
            } while (true);

        }
    }
}
