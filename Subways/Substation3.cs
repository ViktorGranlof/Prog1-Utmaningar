using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Substation3
    {
        public int GetChoice()
        {
            Console.WriteLine("Speakers: Welcome to Subwaystation \"Three\"");

            do
            {
                Console.Write("Do you want to board the train to Subwaystation \"Two\"? y/n: ");
                string val = Console.ReadLine();
                if (val == "y")
                {
                    // Åk till Substation 2
                    Console.WriteLine("You are now leaving Subwaystation \"Three\"");
                    Console.WriteLine("Press enter to continue..");
                    Console.ReadLine();
                    return 2;
                }
                else if (val == "n")
                {
                    // Tar inte tåget, avslutar
                    Console.WriteLine("You left at Subwaystation \"Three\".");
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
