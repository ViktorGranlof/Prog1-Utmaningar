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
            while (result) //Kör programmet när result är true
            {
               result = RunProgram();
            }
        }

        static bool RunProgram()
        {
            Console.WriteLine("Hur många dagar vill du träna på?");

            Training train = new Training(); //Anropar klassen Training 

            string userInput = Console.ReadLine(); //Tar in det användaren skriver in i strängen userInput
            int choice;

            bool worked = int.TryParse(userInput, out choice);

            if (worked == false) //Om det inte tryParse fungerar
            {
                Console.WriteLine("Fel inmatning\n");
                return true;
            }

            for (int i = 0; i < choice; i++) //Skriver ut ett visst antal dagar beroende på användarens "choice"
            {
                Console.WriteLine(train.chooseDay());
            }

            Console.WriteLine("Tryck 1 för att starta om \nSkriv något annat än 1 för att lämna");
            string Continue = Console.ReadLine();

            switch (Continue) //Return true fortsätter programmet när användaren skriver 1, om användaren skriver något annat så returnerar det false
            {                 // och stänger ner programmet. 
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
