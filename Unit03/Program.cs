using System;
using System.Linq;
using System.Collections.Generic;

using System.Text;
using System.Diagnostics;

namespace Unit03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Director director = new Director();
            director.StartGame();











            // //this is testing something
            // string s = "1,2,3,4,5";

            // List<string> result = s?.Split(',').ToList();

            // //Console.WriteLine(String.Join(", ", result)); //it prinst 1, 2, 3, 4, 5 which are all part of a list now. I think.

            // //this is testing plitting the word into a list all of this function is copied word for word from stack overflow under "How do I split a word's letters into an Array in C#?" it is the first thing that pops up when I checked.
            // // static void ExampleFunction(string[] args)
            // // {
            // String word = "r o b o t";

            // String[] token = word.Split(' ');//something should be placed into the () to print letter by letter??

            // int number = 0;
            // string letter = "";
            // int count = 0;
            // foreach (String r in token)
            // {
            //     //Console.WriteLine(r);
            //     number = r[0];
            //     letter = token[count];
            //     count += 1;
            //     //Console.WriteLine($"count is: {count}");
            //     //Console.WriteLine($"letter = {letter}");
            // }
            // //Console.WriteLine($"The word has {count} letters in it.");

            //create a list as long as there are letters in the word. Then place in each index a " _ ".
            // List<string> wordCount = new List<string>();
            // int space = 0;
            // string guessedLetter = " _ ";

            // while (space < count)
            // {
            //     wordCount.Add($" {guessedLetter} "  );
            //     Console.Write(wordCount[0]);
            //     space +=1;
            // }

            //trying to change the value of some of the list
            // List<string> wordCount = new List<string>();
            // int space = 0;
            // string guessedLetter = " _ ";
            // int testNumber = 1;
            // string testString = "a";
            // while (space < count)
            // {
            //     foreach (string r in token)
            //     {
            //         if (testNumber == 1)
            //         {
            //             wordCount.Add($" {testString} r[0]"  );//This Whole last test did not work.
            //         }
            //         else if (testNumber == r[1])
            //         {
            //             wordCount.Add($" {guessedLetter} r[1] "  );
            //         }
            //         else
            //         {
            //             wordCount.Add($" {guessedLetter} "  );
            //         }
            //     }
                
                
                // Console.Write(wordCount[0]);
                // space +=1;
                // testNumber += 1;

                //general notes 
                //cd helps you navigate to specific files to run your code in tapping tab helps fill in spaces but double check before you run.



                // Notes from class to help with the class
                // use a list of strings
                // List<string> aList = new List<string>();
                // aList.Add(@"\\\\\/////");
                // aList.Add(@"\\\///");
                // Console.WriteLine(aList);

                // //use string.join
                // string theWhoeThing = String.Join('\n', aList);
                // Console.WriteLine(theWhoeThing);

                // //Dealing with the hint
                // string appleWord = "apple";
                // Console.WriteLine(word.Length);
                // string hint = "_ _ _ _ _";
                // hint += " _ ";

                // //Check whether a letter is in a word
                // string guess = "a";
                // if (word.Contains(guess))
                // {
                    
                // }

                // //reading lines from a file
                // //List<string> lines = new List<string>(File.ReadLines("sample.txt")); //must be in same area as your code
                // // foreach (var line in lines)
                // // {
                // //     Console.WriteLine(line);
                // // }


                    
                // }
        
            
        }
    }
}
