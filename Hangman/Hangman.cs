using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman2
{
    class Hangman
    {

        public bool PerformGuess(string selectedWord, ref string guessWord, ref int lives) //Ref betyder att kan den ändrar om tidigare tilldelade värden 
        {
            PrintGuessWord(guessWord);          //  

            Console.Write("Your guess: ");
            string input = Console.ReadLine();  //Tar in användarens input
            if (input.Length != 1)              //Är inputet inte 1 karaktär körs detta
            {
                Console.WriteLine("Write only a single character...");
                return true;
            }

            if (LetterInWord(selectedWord, input))  //Kollar om användaren gissat rätt eller fel, true eller false
            {
                AddLetter(selectedWord, ref guessWord, input); //En metod som 
                if (selectedWord == guessWord) //Om det valda ordet i ordlistan är detsamma som det hela gissade ordet körs detta
                {
                    Console.WriteLine("\nCorrect guess, it was " + guessWord + "! \n\nYou won! Press any button to exit");
                    Console.ReadLine();
                    return false;
                }
            }
            else
            {
                lives--;           //Inkrementerar lives med 1
                if (lives == 0)    //Är lives noll
                {
                    Console.WriteLine("You lost! The correct word was: " + selectedWord + ". Press any button to exit");
                    Console.ReadLine();
                    return false;       //Returnernar false som gör att programmet stänger ner
                }
                Console.WriteLine("Wrong! You got: " + lives + " chances left"); //Visar spelaren hur många liv som är kvar efter att ett liv blivit förlorat
            }
            return true;
        }

        public void PrintGuessWord(string guessWord) //En metod som skriver ut det gissade ordet 
        {
            for (int i = 0; i < guessWord.Length; i++) //För längden av guessword skrivs ett '_' ut och efter det ett mellanslag ' '
            {
                Console.Write(guessWord[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public bool LetterInWord(string selectedWord, string input)
        {
            if (selectedWord.IndexOf(input, StringComparison.OrdinalIgnoreCase) == -1) // String.Comparison.OrdinalIgnoreCase'
            {                                                                        // Ser till att inputet inte är case sensetive
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddLetter(string selectedWord, ref string guessWord, string input) // En metod som skickar in selectedWord, en ändringsbar string och en input.
        {
            int startIndex = 0; // Ger startIndex ett värde 0
            do
            {
                int index = selectedWord.IndexOf(input, startIndex, StringComparison.OrdinalIgnoreCase); // Letar efter position av den inslagna bokstaven
                if (index != -1)
                {
                    char[] guess = guessWord.ToCharArray(); // Gör om guessWord till en char array för att kunna modifiera ordet för att kunna bytas ut
                    guess[index] = selectedWord[index];     // Tar bokstaven från index och stoppar in bokstaven i ordet 
                    guessWord = new string(guess);          // Sparar den nya strängen med bokstaven i den
                    startIndex = index + 1;                 // Ökar på indexet så att den kollar igenom alla platser i ordet
                }
                else
                {
                    startIndex = index;                     // Körs om ingen angiven bokstav fanns i ordet, hoppar ur loopen
                }

            }
            while (startIndex != -1); //Kör medan startIndex inte är -1
        }
    }
}
