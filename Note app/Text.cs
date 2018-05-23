using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_App2
{
    class Text
    {
        public string writtenText; // En publik variabel

        public string headLine;

        public Text(string writtenText, string headLine) //En konstruktor som tar in strängen writtenText
        {
            this.writtenText = writtenText;
            this.headLine = headLine;
        }

        public void printHeadLine(int tal) //Skriver ut rubriken som användaren valt 
        {
            Console.WriteLine(tal + ": " + headLine);
        }

        public void printText() //Skriver ut texten som användaren skrivit in 
        {
            Console.WriteLine(writtenText);
        }
    }
}
