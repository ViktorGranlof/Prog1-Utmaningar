using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordList = new string[6]; //Skapar en array med ord som agerar ordlista
            wordList[0] = "Laddare";
            wordList[1] = "Betyg";
            wordList[2] = "Programmering";
            wordList[3] = "Matematik";
            wordList[4] = "Datormus";
            wordList[5] = "Pepparkaka";

            Random rng = new Random();

            int wordIndex = rng.Next(0, wordList.Length); //Väljer ut ett slumpmässigt tal

            Console.WriteLine("THE GAME OF HANGMAN!");

            Console.WriteLine();
            Console.WriteLine("Här är ditt gissningsord!");
            Console.WriteLine();

            string selectedWord = wordList[wordIndex]; // Väljer ett slumpartat ord och ger variabeln 

            string guessWord = "";
            for (int i = 0; i < selectedWord.Length; i++)
            {
                guessWord += "_";
            }

            int lives = 5; //Ger spelaren ett bestämt antal liv

            Hangman hangman = new Hangman(); //Anropar klassen Hangman

            bool continueGuess = true;
            do
            {
                continueGuess = hangman.PerformGuess(selectedWord, ref guessWord, ref lives); //Skickar in det slumpade ordet, skickar in gissningsorden "__" och de liv man har
            }
            while (continueGuess);
        }

    }

}