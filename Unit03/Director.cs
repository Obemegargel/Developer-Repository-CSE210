namespace Unit03
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Jumper _jumper = new Jumper();
        private TerminalService _terminalService = new TerminalService();
        private Word _word = new Word();
        private bool _isPlaying = true;
        private bool jumper = true;
        private bool wordFound = true;
        private bool guess = true;
        private string hint = "testing hint";
        private string paraHint = "testing paraHint";
        private string letter = "testing letter";

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            _word.ChooseWord();
            //hint = _word.guessList();//***********
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
        /// Ask the Service Terminal (that you created a new instance of at the beginning) to write a message in the terminal.
        /// Then the Terminal Service class will read what the user inputs.
        /// The value the user enters gets saved into the "letter" string variable only used in this function.
        /// Then, this function calls the the word class instance's LetterInWord function (we created this instance of the class in the beginning and saved it as _word)
        /// When this class's function is called a value is sent to be used in that function in that class.
        /// The value is the "letter" varaible that has the user's input saved.
        /// </summary>
        private void GetInputs()
        {  // _terminalService.WriteText(wordHint);//***********
            //_terminalService.WriteText(_jumper.GiveParachute());
            //_terminalService.WriteText(hint);//***********
            letter = _terminalService.ReadText("\n Enter a letter: ");
            guess =_word.LetterInWord(letter);//used to be _seeker.MoveLocation(location);
            
        }

        /// <summary>
        /// The function asks a value from the word class. When GetInputs() called for the word Class's LetterInWord() function it sent it a value of
        /// letter inside the parenthasis. This value was used in the word class to conlude if the letter(user's guess) was in the word or not.
        /// Then this function calls the Word class's LetterISFound() function which returns a bool. If the bool is false(the letter was not in the word)
        /// Then the Jumper class's CutLine() function is called. This function cuts the first item in a list of strings that draws the parachute in the 
        /// terminal(TerminalService could be called in the Jumper class to display this to the terminal).
        /// 
        /// Then this function also checks the Jumper Class's IsDead() Function and the Word Class's IsFound() function.
        /// If either are true, then _isPlaying is changed to false. This ends the game(see This Class's StartGame function to see why).
        /// </summary>
        private void DoUpdates()
        {
            //if not guess
            if (!guess)//.Contains(_word.guessList())//***********
            {
               _jumper.CutLine();//_hider.WatchSeeker(_seeker); // _isPlaying
            }
            hint = _word.WordHint();
            paraHint = _jumper.ParachuteHint();

            jumper = _jumper.IsDead();
            wordFound = _word.WordFound();

            //if jumper is dead or word found = true
            //_isPlaying = false;
            if (jumper == true || wordFound == true)
            {
                _isPlaying = false;
            }
            

        }

        /// <summary>
        /// Calls the ServiceTerminal class to write the variabe "hint" into the terminal.
        /// </summary>
        private void DoOutputs()
        {
            //string hint = _jumper.DisplayWord();//string hint = _hider.GetHint(); //SOmething is not correct here.//_guess.GetLetter()
            //string hint = _jumper.CutLine();//This is a test variable
           _terminalService.WriteText(hint);//test
            _terminalService.WriteText(paraHint);

            //_terminalService.WriteText(hint);//test//***********

            // hint = _jumper.CutLine();
            // wordHint = _word.guessList();//test
            //string hint = _jumper.MakeParachute();//not needed
            //_terminalService.WriteText(wordHint);//***********
            //_terminalService.WriteText(hint);



            // if (_jumper.IsDead())//if (_hider.IsFound())// may not need this because it is in DoUpdates()
            // {
            //     _isPlaying = false;
            // }

        }

        ///<summary>
        ///accesses the test.cs file
        ///</summary>
        // private void TestFunction()
        // {
        //     test _testerer = new test();
        // }
    }
}