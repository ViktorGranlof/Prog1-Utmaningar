using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Träningschema
{
    class Training
    {
        Random rng = new Random(); //Använder Random för att låta programmet själv välja slumpartat 

        string[] trainingDays = new string[] { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag" }; //Gör en array med alla dagar

        public string chooseDay()
        {
            System.Threading.Thread.Sleep(1000); //Gör så att programmet väntar 
            int wordIndex = rng.Next(0, trainingDays.Length); //Väljer ett random 

            return trainingDays[wordIndex];
        }
    }
}
