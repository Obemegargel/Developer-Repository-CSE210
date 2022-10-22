﻿using System;

namespace Unit02
{
    class Program
    {
       /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static int Main(string[] args)//code can take arguments passed through here
        {
            Director director = new Director();//called director class's constructor to make a new thing.
            director.StartGame();
            return 0;//returns a zero so if a different number gets generated by another function it can end the program.
        }
    }
}
