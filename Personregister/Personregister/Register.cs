using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Register
    {
        // List-objekt för att hålla våra djur 
        List<Personer> personLista;

        // Konstruktor 
        public Register()
        {
            personLista = new List<Personer>(); // Gör en ny lista 

            FillWithPeople();
        }

        void FillWithPeople() //
        {
            FillPersoner();
        }

        void FillPersoner()
        {
            // Skapar tre objekt av Personer
            Personer viktor = new Personer("Viktor", 18, "Falun");
            Personer albert = new Personer("Albert", 32, "Örebro");
            Personer isak = new Personer("Isak", 25, "Malmö");

            // Lägger till personerna i 'personLista'
            personLista.Add(viktor);
            personLista.Add(albert);
            personLista.Add(isak);
        }

        public void addPerson(string name, int age, string location) //När 
        {
            Personer x = new Personer(name, age, location);
            personLista.Add(x);
        }

        public void ListPersoner()
        {
            foreach (Personer p in personLista)
            {
                Console.WriteLine(p.GetName());
            }
        }
        public void WritePerson(string namn)
        {
            foreach (Personer p in personLista)
            {
                if(p.GetName() == namn)
                {
                    Console.WriteLine("Namn: " + p.GetName());
                    Console.WriteLine("Ålder: " + p.GetAge());
                    Console.WriteLine("Stad: " + p.GetLocation());
                }
            }
        }
    }
}
