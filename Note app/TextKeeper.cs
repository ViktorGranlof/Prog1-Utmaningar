using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_App2
{
    class TextKeeper
    {
        List<Text> textList = new List<Text>(); 

        public bool Menu()
        { 
            Console.WriteLine("\nSkriv 1 för att lägga till antecnkingar " +
                "\nSkriv 2 för att ta bort anteckningar \nSkriv 3 för att visa antecningar \nSkriv 4 för att avsluta\n");
            string input = Console.ReadLine();   //Kollar vad användaren skriver in

            if (input == "1")      // Gör en if sats där användaren kan skriva in 1 för att lägga till text, två för att ta bort antekningarna
            {                      // 3 för att visa anteckningar och 4 för att avsluta, om man skriver in annat kommer den att köra om if satsen
                AddText();
            }
            else if (input == "2")
            {
                Console.WriteLine("Vilken anteckning vill du ta bort?");
                string userInput = Console.ReadLine();        //Tar in det användaren skriver
                int inputs = Convert.ToInt32(userInput);      //Konverterar användarens input till en int
                textList.RemoveAt(inputs-1);                  //Tar bort den text i positionen där användarens input matchar
                // textList.Clear();        //Rensar hela listan                                       
            }                                                                     
            else if (input == "3")
            {
                Console.WriteLine();
                PrintTexts();         //Kör metoden printtexts
            }
            else if (input == "4")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Ogilitig inmatning");
            }

            return true;
        }

        public void AddText()
        {
            Console.WriteLine("\nDin rubrik: \n");
            string headLine = Console.ReadLine();
            Console.WriteLine("\nDin text: \n");
            string text = Console.ReadLine();

            textList.Add(new Text(text, headLine)); //Lägger till siffran för sedan ett mellanslag och sedan den inskrivna texten
        }

        public void PrintTexts() // En metod som skriver ut talen
        {
            int tal = 1;

            foreach (Text written in textList) //Skriver ut en text för varje text i textlistan, ger den också ett värde
            {
                written.printHeadLine(tal);
                tal++;
            }
            
            Console.WriteLine("\nSkriv in numret på din rubrik för att läsa texten\n");
            string headLineChoice = Console.ReadLine();
            Console.WriteLine("");
            int userChoice = 0;
            bool success = int.TryParse(headLineChoice, out userChoice); //Gör en bool som innehåller headLineChoice och userChoice
            
            if (success) //Om sant
            {
                if (userChoice > 0 && userChoice <= textList.Count) //Userchoice ska vara större än noll och mindre än eller lika med alla platser i textList
                {
                    textList[userChoice - 1].printText();
                }
                else
                {
                    Console.WriteLine("Skriv in ett nummer som redan existerar!");
                }
            }
            else
            {
                Console.WriteLine("Fel inmatning");
            }
        }

    }
}
