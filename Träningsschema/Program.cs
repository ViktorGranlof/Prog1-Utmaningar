using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Träningschema
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            while (result)
            {
               result = RunProgram();
            }
        }

        static bool RunProgram()
        {
            Console.WriteLine("Hur många dagar vill du träna på?");

            Training train = new Training();

            string userInput = Console.ReadLine();
            int choice;

            bool worked = int.TryParse(userInput, out choice);

            if (worked == false)
            {
                Console.WriteLine("Fel inmatning");
                Console.WriteLine();
                return true;
            }

            for (int i = 0; i < choice; i++)
            {
                Console.WriteLine(train.chooseDay());
            }

            Console.WriteLine("Tryck 1 för att starta om \nSkriv något annat än 1 för att lämna");
            string Continue = Console.ReadLine();

            switch (Continue)
            {
                case "1":
                    return true;
                    break;

                default:
                    return false;
                    break;
            }
            return true;
        }
    }
}
