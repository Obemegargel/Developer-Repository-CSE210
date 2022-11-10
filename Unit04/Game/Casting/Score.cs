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
        public Score()
        {

        }

        public void SetScore(int value)
        {
            scoreBoard += value;
            //return scoreBoard;
        }

        public string GetScore()
        {
            return scoreBoard.ToString();
        }
    }
}