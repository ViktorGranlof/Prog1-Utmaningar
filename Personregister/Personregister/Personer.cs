using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Personer
    {
        // Privata instansvariabler
        private string name;
        private int age;
        private string location;

        // Konstruktor som tar in namn, ålder och plats, används sedan i register när man skapar objekt 
        public Personer(string name, int age, string location)
        {
            this.name = name;
            this.age = age;
            this.location = location;
        }

        public string GetName() 
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetLocation()
        {
            return location;
        }

        // Public metod 
        public string GetInfo()
        {
            return $"{name} är {age} år gammal och bor i {location}. ";
        }
    }

}
