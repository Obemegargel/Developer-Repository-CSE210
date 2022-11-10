using System;
using System.Collections.Generic;


namespace Unit03
{
    public class Word
    {
        private List<string> guesses = new List<string>(){};
        private List<string> badGuesses = new List<string>();
        private List<string> goodGuesses = new List<string>();
        //private string guesses = "";
        bool inWord = false;
        bool wordFound = false;//preset to false just for fun
        public string word = "apple";//this is for chooseWord()

        public string part = " ";
        // public int counter = 0;

        //*********
        // int wordLen = 5;
        // private string part = " ";

        /// <summary>
        /// This function selects the word for the user to guess.
        /// </summary>
        public void ChooseWord()
        {
            word = "apple";
            foreach (char i in word)
            {
                //guesses += " _ ";
                guesses.Add("_");
                //Console.WriteLine(i);
            }
        }

        /// <summary>
        /// This takes the value "letter" from the director and saves that in a variable it also calls letter
        /// it checks the letter to see if it is found in the word.
        /// If it is found variable letterFound = true;
        /// returns letterFound
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        public bool LetterInWord(string letter)
        {
            part = letter;
            //Console.WriteLine($"part: {part}");//test**************
            //if (guesses.Contains(letter))
            //{
            //guesses.Add(letter);
            //Console.WriteLine($"guesses list: {guesses} letter: {letter}");
            //}
            //check if the letter is in the word then return a bool called keep going
            if (word.Contains(letter))
            {
                inWord = true;
            
            }
            else
            {
                inWord = false;
            }
            return inWord;
            //string listToString = String.Join('\n', guesses);//this may be deleted
            // return String.Join('\n', guesses);
            //return letterFound;
        }

        public string WordHint()
        {
            //int counter = 0;//up at top
            // letterFound = true;

            //Console.WriteLine($"i: {i}");//****************
            int counter = 0;
            foreach (char c in word)
            {
                
                if (word[counter].ToString() == part)// i.ToString() == part
                {
                    guesses[counter] = c.ToString();
                    // Console.WriteLine($"WordHint loop 1: {i} and part: {part}");//************
                    //guesses[0] = part;
                    //guesses.Add($" {part} ");
                    //goodGuesses.Add($" {guesses[counter]} ");
                    //guesses[counter] = $" {i.ToString()} ";
                    //guesses += $" {i} ";
                    //guesses.Add("testing");
                }
                else
                {
                    //guesses.Add("nottesting");
                    //badGuesses.Add($" {i.ToString()} ");
                    // guesses.Add(" _ ");
                    //guesses[0+counter] = " _ ";
                    // guesses += " _ ";
                    //guesses[counter] = " _ ";
                    //guesses[counter] = " _ ";// ☆ □ ● ■ ○ • ° ▪︎¤ ♧ ◇ ♡ ♤ € £ ¥ ₩ ¿ ¡ //just for fun to know
                }
                counter += 1;


                    //Console.WriteLine(guesses);//test
            }
            
            //Console.WriteLine($"letterFound: {letterFound}");//test
            // int step = 0;
            // LetterInWord(part);

            //string stringifyGuesses = String.Join(' ', guesses);
            return String.Join(' ', guesses);// or '\n'
            //return guesses;
        }

        /// <summary>
        /// in order to see if the entire word has been guessed, It loops through the string word
        /// If every letter it looks at in the word is in the list "guesses" then the whole word is guessed.
        /// The word found is changed to true when the whole word is guessed.
        /// </summary>
        /// <returns> bool wordFound </returns>
        public bool WordFound()
        {
            foreach (char i in word)
            {
                if (!guesses.Contains(i.ToString()))
                {
                    return false;
                }
                else
                {
                    wordFound = true;
                }
            }
            return wordFound;
        }



    }
}