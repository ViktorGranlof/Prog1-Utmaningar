using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Viktor's program"; //Byter namnet på programmrutan
            TextKeeper tk = new TextKeeper();   

            bool Continue = true;               // Ger bool värdet true

            while (Continue)                    // Kör medans Continue är sann, vilket det kommer vara ända tills användaren skriver in 4 i if satsen
            {
                Continue = tk.Menu();
            }
        }
    }
}
