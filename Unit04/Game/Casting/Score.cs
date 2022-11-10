using System;
using System.Collections.Generic;


namespace Unit04.Game.Casting
{
    
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Actor is to keep track of its appearance, position and velocity in 2d 
    /// space.
    /// </para>
    /// </summary>
    public class Score
    {
        private int scoreBoard = 0;

        /// <summary>
        /// Creates a new instance of the Score
        /// </summary>
        public Score()
        {

        }

        /// <summary>
        /// Adds the possitive or negative value(depending on what the value is) to the scoreboard.
        /// </summary>
        /// <param name="value"></param>
        public void SetScore(int value)
        {
            scoreBoard += value;
            //return scoreBoard;
        }

        /// <summary>
        /// Sends the scoreBoard value to the Director
        /// </summary>
        /// <returns></returns>
        public string GetScore()
        {
            return scoreBoard.ToString();
        }
    }
}