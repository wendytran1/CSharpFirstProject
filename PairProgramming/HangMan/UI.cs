using HangManClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class UI
    {
        public void Run()
        {
            Console.WriteLine("We're about to play Hangman!");
            Console.ReadLine();
            Board board = new Board("apple", "fruit");
            Console.WriteLine($"The word's category is {board.WordCategory} and there are {board.WordToGuess.Length} letters in the word.");
            Console.ReadLine();

            bool gameIsNotFinished = true;
            while (gameIsNotFinished)
            {
                Console.Clear();
                //Output to console the current board. the word currently and letters guessed.
                Console.WriteLine("Current word progress:");
                Console.WriteLine(board.GetWordWithUserGuesses());

                Console.WriteLine("Current guessed letters:");
                OutputCurrentGuessedLetters(board);

                //Ask the user for another letter.
                Console.WriteLine("Please enter a single letter that you would like to guess:");
                char userInput = GetUserInputAsCharacter();

                //Determine if the letter is in the word.
                //Tell the user if it is or isn't

                Console.WriteLine($"You guessed: {userInput}");

                board.LettersGuessed.Add(userInput);

                if (board.WordToGuess.Contains(userInput))
                {
                    Console.WriteLine("The letter is in the word!");
                }
                else
                {
                    Console.WriteLine("Sorry the letter is not in the word.");
                    board.NumberOfUserIncorrectGuess += 1;
                }

                //Determine if the game is over.
                //either the user has guessed the word.
                if (board.WordIsComplete())
                {
                    Console.WriteLine($"You have won! The word is {board.WordToGuess}.");
                    gameIsNotFinished = false;
                }
                //or they have guessed wrong too many times.
                else if (board.NumberOfUserIncorrectGuess == 6)
                {
                    Console.WriteLine("You're out of guesses! You let the person get hanged!");
                    gameIsNotFinished = false;
                }

                Console.ReadLine();
            }

        }

        private static char GetUserInputAsCharacter()
        {
            char userInputAsChar = '\'';
            while (userInputAsChar == '\'')
            {
                string userInput = Console.ReadLine();
                try
                {
                    userInputAsChar = char.Parse(userInput);
                }
                catch
                {
                    Console.WriteLine("Input was invalid. Type a single character letter please.");
                }
            }
            return userInputAsChar;
        }

        private static void OutputCurrentGuessedLetters(Board board)
        {
            int iteration = 0;
            foreach (char letter in board.LettersGuessed)
            {
                iteration++;
                if (iteration == board.LettersGuessed.Count)
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.Write($"{letter}, ");
                }
            }
        }
    
    
    }
}
