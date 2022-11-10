using System;
using System.Collections.Generic;


namespace Unit03
{
    public class Jumper
    {
        private bool dead = false;//starts as alive. I think this will be changed before anything happens so it does not matter which it starts at.
        //List<string> parachute = new List<string>();
        List<string> parachute = new List<string>() { @"  ___ ", @"/     \", @"_______", @"\     /", @" \   /", @"   0 ", @"  /|\ ", @"  / \ ", @"^^^^^^^" };
        private string listToString = "testing listToString";

        int limit = 4;//this is the number of tries you get before the game is over and the parachute is gone.

        //private string word;
        // private List<string> parachute = new List<string>();
        // private List<string> letterSpaces = new List<string>();

        //public string _character = "h";

        /// <summary>
        /// This function sets a default for the jumper class in case no values are entered. 
        /// No functions require this in order to operate so it remains empty.
        /// </summary>
        public void jumper()
        {

        }

        /// <summary>
        /// This function cuts the line of the parachute.
        /// This means it removes the first value of a list that houses all the rows that when displayed make a picture of a parachute.
        /// Each row is a single segment in the list.
        /// In the director it only calls this function if the conditions apply where it would cut the line.
        /// This means no checks or balances are needed inside this function because they are already handled before this is called.
        /// It is taken care of outside of this function.
        /// </summary>
        /// 
        // public void MakeParachute()
        // {
        //     //Cut the first index value of the list called parachute.
        //     //When this function is called it means the person messed up. They only have so many tries before the parachute is gone.
        //     //There will be a variable that adds one each time this function is called. When the number reaches the limit it will later determine
        //     //another function called IsDead() it returs true when the limit is reached.
        //     //Note: another way to get the same result is have a list counter that if the list gets to a certainly small number that value determines 
        //     //if it is true or false. if you use the first method you must make a variable at the top of the class for all the functions to access so the
        //     //checking fuction can read the variable value. If you choose the other route you probably must change it as well. 
        //     //You must also create a limit variable for the other variable to be compared to.

        //     //add each layer to a list.
        //     parachute.Add(@"  ___ ");
        //     parachute.Add(@"/     \");
        //     parachute.Add(@"_______");
        //     parachute.Add(@"\     /");
        //     parachute.Add(@" \   /");
        //     parachute.Add(@"   0 ");
        //     parachute.Add(@"  /|\ ");
        //     parachute.Add(@"  / \ ");
        //     parachute.Add(@"^^^^^^^");

        //     //turn the list into a string so it can be returned as a string to be sent to the director which calls it to
        //     //the ServiceTerminal as a string.
        //     //string listToString = String.Join('\n', parachute);

        //     //return listToString;

        // }

        /// <summary>
        /// Combine the list into a string.
        /// </summary>
        public string ParachuteHint()
        {
            listToString = String.Join('\n', parachute);//this may be deleted
            return listToString;
        }

        /// <summary>
        /// this function "cuts the parachute". It removes the first item in the list.
        /// </summary>
        public void CutLine()
        {
            //turn the list into a string so it can be returned as a string to be sent to the director which calls it to
            //the ServiceTerminal as a string.
            //Console.WriteLine($"parachute list: {parachute}");
            // string listToString = String.Join('\n', parachute);//this may be deleted//***************
            //Console.WriteLine($"listToString string: {listToString}");

            parachute.RemoveAt(0);//parachute = parachute.ToList().RemoveAt(0).ToArray(); or replace parachute with listToString and put this line under next code line
            //string listToString = String.Join('\n', parachute);

            //return listToString;
        }

        

        /// <summary>
        /// This checks if the number of strikes the user guesses reached the limit.
        /// If it reached the limit then we know the list containing parachute must already
        /// be depleated to imply the person is alone and therefor died.
        /// If the person is dead, dead = true then the director will use this value to end the game.
        /// if the person is not dead(have not guessed all their guesses) then dead = false, director lets game
        /// keep going.
        /// </summary>
        /// <returns> bool dead </returns>
        public bool IsDead()
        {
            //if the limit is reached then dead = true
            //if the limit is not reached yet, then dead = false
            if (parachute.Count <= limit)
            {
                dead = true;
            }
            else
            {
                dead = false;
            }
            return dead;
        }

        // private void Word()
        // {
        //     word = "word";
        // }

        // public bool IsletterInWord()
        // {
        //     if (word.Contains(_character))
        //     {
        //         letterFound = true;
        //     }
        //     else
        //     {
        //         letterFound = false;
        //     }
        //     Console.WriteLine($"Test: letterFound varaible = {letterFound} (This message is found in Jumper class, IsLetterInWord function");
        //     return letterFound;
        // }

        /// <summary>
        /// This creates a string list that has the parachute and man.
        /// It will take a parameter from ______ that is a bool. Depending on what the bool is one item will be taken from the list.
        /// </summary>
        // public void Parachute()
        // {
        //     IsletterInWord();
        //     if (IsletterInWord() == true)
        //     {
        //         Console.WriteLine($"Parachute list should not be cut");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Parachute list should be cut.");
        //     }

            
        // }

        /// <summary>
        /// Displays a list that houses " _ " as well as replaces the correct " _ " with the letter the user enters.
        /// This takes the variable from TerminalService for the letter that was entered by the user through the Guess Class.
        /// </summary>
        // public List<string> DisplayWord(Word letR)//Guess letter
        // {
        //     Console.WriteLine($"jumper DisplayWord function: Here is where the '_' list goes that gets replaced by letR: {letR._character}the Guess class guesses from user");
        //     //letterSpaces = letterSpaces.Add();//letR._character  //This should add variable letR to the end of the list. But error occurs.
        //     return letterSpaces;
        // }

        /// <summary>
        /// This Class tells the Guess Class 
        /// </summary>
        /// <returns></returns>
        // public string GetHint()
        // {
        //     string stringVariable = "testGetHint()";
        //     return stringVariable;
        // }

    //     public void WatchSeeker(Word variable)//This variable is for the method alone. Not sure what it takes care of yet, will likely change. it is type Encapsulator
    //     {
    //     }
        
    //     public bool IsFound()
    //     {
    //         bool boolVariable = true;
    //         return boolVariable;
    //     }
    }

    
}