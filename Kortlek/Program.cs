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
            string userInput = Console.ReadLine();  //Tar in det användaren skriver
            int inputs = Convert.ToInt32(userInput); //Konverterar användarens input till int
            Kortlek kortlek1 = new Kortlek();  //Anropar Kortlek

            for (int i = 0; i < inputs; i++)  //När "i" är mindre än användarens input körs detta och inkrementera "i" med 1
            {
                Console.WriteLine(kortlek1.drawCard()); //Skriver ut ett random kort med hjälp av metoden drawCard i klassen Kortlek
            }
            Console.ReadLine();
        }
    }
}
