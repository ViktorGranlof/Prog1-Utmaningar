using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Subway
{
    class Program
    {
        static void Main(string[] args)
        {
            int stationsval = 1;

            do
            {
                switch(stationsval)
                {
                    case 1:
                        // Skapar ett objekt av station1 och frågar vilken station vi ska åka till
                        Substation1 station1 = new Substation1();
                        stationsval = station1.GetChoice();
                        break;

                    case 2:
                        Substation2 station2 = new Substation2();
                        stationsval = station2.GetChoice();
                        break;

                    case 3:
                        Substation3 station3 = new Substation3();
                        stationsval = station3.GetChoice();
                        break;

                    default:
                        return;
                }

            }
            while (true);
        }
    }
}
