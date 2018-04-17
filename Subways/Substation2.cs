using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Substation2
    {
        public int GetChoice()
        {
            Console.WriteLine("Speakers: Welcome to Subwaystation \"Two\"");

            do
            {
                Console.WriteLine("You see two trains.. ");
                Console.WriteLine("Go to Subwaystation \"One\": 1");
                Console.WriteLine("Go to Subwaystation \"Three\": 2");
                Console.WriteLine("Leave the Subway: 3");
                Console.Write("Your choice: ");
                string val = Console.ReadLine();
                if (val == "1")
                {
                    // Åk till Substation 1
                    Console.WriteLine("You are now leaving Subwaystation \"Two\"");
                    Console.WriteLine("Press enter to continue..");
                    Console.ReadLine();
                    return 1;
                }
                else if (val == "2")
                {
                    // Åk till Substation 3
                    Console.WriteLine("You are now leaving Subwaystation \"Two\".");
                    Console.WriteLine("Press enter to continue..");
                    Console.ReadLine();
                    return 3;
                }
                else if (val == "3")
                {
                    // Tar inte tåget, avslutar
                    Console.WriteLine("You left at Subwaystation \"Two\"" );
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
