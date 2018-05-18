using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortlek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många kort vill du dra...? ");
            string userInput = Console.ReadLine();
            int inputs = Convert.ToInt32(userInput);
            Kortlek kortlek1 = new Kortlek();

            for (int i = 0; i < inputs; i++)
            {
                Console.WriteLine(kortlek1.drawCard());
            }
            Console.ReadLine();
        }
    }
}
