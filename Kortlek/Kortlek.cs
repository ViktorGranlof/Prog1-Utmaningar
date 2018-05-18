using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortlek
{
    class Kortlek
    {
        Random rng = new Random();  //Använder systemets egna random funktion
        string[] kort = new string[52];   //Gör en array med 52 platser.

        public Kortlek()
        {
            string[] cardColour = new string[4]; //Gör en array med kortens olika färger
            cardColour[0] = "Klöver";
            cardColour[1] = "Spader";
            cardColour[2] = "Ruter";
            cardColour[3] = "Hjärter";

            string[] cardValue = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Knekt", "Dam", "Kung" };
                                             //En till array fast denna gång med kortens olika värden 
            int cardIndex = 0;

            for (int colour = 0; colour < cardColour.Length; colour++)  //Väljer en slumpmässig färg
            {
                 for (int value = 0; value < cardValue.Length; value++) //Väljer ett slumpmässigt nummer
                {
                    kort[cardIndex] = cardColour[colour] + " " + cardValue[value];
                    cardIndex++;
                 }
            }  
        }

        public string drawCard()
        {
            System.Threading.Thread.Sleep(1);         // Ber systemet att vänta 1 milisekund för att random inte ett ska använda ett och samma "seed" 
            int wordIndex = rng.Next(0, kort.Length); // flera gånger på grund av klock-cykeln. Genom att vänta väljs ett nytt seed ut. 

            return kort[wordIndex];
        }
    }
}
