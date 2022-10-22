using System;
using System.Collections.Generic;

namespace Unit02
{
    
    public class Card
    {
        // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 
        // public bool _isPlaying = true;
        // public int _score = 100;//attribute
        // public int _totalScore = 300;

        public int value;

        // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Card()//This may make every card you get right add 300 points. I would need to change this if that happens.
        {
            
        }

        // 3) Create the Roll() method. Use the following method comment.
        
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
        public void flipCard()
        {
            //Random getCard = new Random();
            //returns a random number until it gets up to 5 numbers
            //value = getCard.Next(14);//14 only includes 13 which is how many cards we want. two numbers would be between # and 2nd# but not including 2nd#
            //Console.WriteLine($"{value}");//returns random integer between 1 - 10
            Random getCard = new Random();
            value = getCard.Next(14);
            //Console.WriteLine($"{value}");
            // Card newCard = new Card();//instance of die @! may not need to be points could have to be a different name.
            // newCard._isPlaying = true;//attributes preasigned to be written over when new dice has different value for these points.
            // //newCard._score = 0;
            // //newCard._totalScore = 300;
            
        } 

        //could reate an IsLessThan() and DisplayCard() method to be called

    }

    
    

    
    
        
}