using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tal_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resultat;
            do                          
            {
                resultat = TalPyramid();
            }
            while (resultat == false); //Kör programmet medan resultatet är falskt
        }
        static bool TalPyramid()
        {
            Console.WriteLine("Skriv in ett tal: ");
            string input = Console.ReadLine();
            long tal1 = 0;
            try //Försöker köra programmet  
            {
                tal1 = Convert.ToInt64(input);
            }
            catch(Exception e) //Returnerar false om ett fel hittas som gör att programmet körs om igen
            {
                Console.WriteLine();
                Console.WriteLine("Fel inmatning");
                return false;
            }
            for (int i = 0; i < tal1 + 1; i++) //Kör igenom och plussar på i för varje loop
            {
                for (int j = 0; j < i; j++)    //Nästlad for-loop som plussar på j för varje loop
                {
                    Console.Write(tal1);       //Skriver ut ett visst antal tal beroende på hur många gånger loopen kördes
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Skriv något för att lämna programmet"); //Avslut
            Console.ReadLine();
            return true; //Returnernar true vilket gör att 'bool resultat' inte kör igen
        }
    }
}

