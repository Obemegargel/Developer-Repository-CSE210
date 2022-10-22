using System;
using System.Collections.Generic;
//using Unit02.game //(This allows you to import a class with a different namespace than the director. For instance if Cards.cs had the namespace Unit02.game instead of just unit02 this would be needed.)

namespace Unit02
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        //Card card = new Card();
        Card previousCard = new Card();
        Card currentCard = new Card();
        List<Card> _card = new List<Card>();//list of dice
        bool _isPlaying = true;//member variable, attribute, variable for this class
        //int _score = 0;
        int _totalScore = 300;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            
            //Card value2 = new Card();
            //Console.WriteLine($"value1: {value1.value} and value2: {value2.value}");
            //Console.WriteLine($"testing: {previousCard.value}");
            //Console.WriteLine($"testing: {previousCard.flipCard}");
            // List<Card> _card = new List<Card>();
            // for (int i = 0; i < 2; i++)//create 5 die
            // {
            //     Card nextCard = new Card();
            //     _card.Add(nextCard);//add die to the list of dice
            // }
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to draw a card.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Keep playing? [y/n] ");
            string flipTheCard = Console.ReadLine().ToLower();//ToLower() was added but not needed. this makes it lowercase. you could put this in line below this one.
            _isPlaying = (flipTheCard == "y");//if user enters "y" then _isPlaying stays true. This controles the while loop. This is a simplified if loop
            

        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            //(value) ? ValueTuple: (2nd condition) ? value || = Or
            currentCard.flipCard();
            previousCard.flipCard();

            if ((!_isPlaying) || (_totalScore <= 0)) //if _isPlaying is false or totalScore is 0
            {
                return;
            }
            else
            {
                DoOutputs();//may need to be removed
                Console.WriteLine("Will the next card be higher or lower? [h/l]");
                string hilo = Console.ReadLine().ToLower();
                // Card nextCard = new Card();
                // int test = 10;//testing the program
                //if statement comparing value
                if ((currentCard.value >= previousCard.value) && (hilo == "h"))
                {
                    _totalScore += 100;
                    Console.WriteLine($"{currentCard.value} is larger than {previousCard.value}.");

                }
                else if ((currentCard.value <= previousCard.value) && (hilo == "l"))
                {
                    _totalScore += 100;
                    Console.WriteLine($"{currentCard.value} is smaller than {previousCard.value}.");

                }
                else
                {
                    _totalScore -= 75;
                    Console.WriteLine($"Incorrect");
                }
                // if ((hilo == "h") && (test == 10))
                // {
                //     _totalScore = _totalScore + 100;
                //     Console.WriteLine($"The DoUpdates() seemed to work!");
                //     Console.WriteLine($"{_totalScore}");//also for a test
                // }

            }
            // _score = 0;//otherwise set to zero
            // foreach (Card newC in _card)//loop through dice list
            // {
            //     newC.flipCard();//this is a method name in the class file, call the roll method for each die in the Die class.
            //     _score += newC.points; //add the point value saved in the method. There is a member variable called points inside the Roll method.
            // }
            
        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }



            Console.WriteLine($"The card is: {previousCard.value}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
        }
    }
}


