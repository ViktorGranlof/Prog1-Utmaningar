using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Träningschema
{
    class Training
    {
        Random rng = new Random();

        string[] trainingDays = new string[] { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag" };

        public string chooseDay()
        {
            System.Threading.Thread.Sleep(1000);
            int wordIndex = rng.Next(0, trainingDays.Length);


            return trainingDays[wordIndex];
        }
    }
}
