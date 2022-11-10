namespace Unit04.Game.Casting{
        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a message about itself.
        /// </para>
        /// </summary>
    class Artifact : Actor{
        private string _artifact;
        private int _artifactValue;

        private string bomb = "0";
        private string gem = "*";
        private int value;
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact(){
            _artifact = "artifact"; //***************
            //_artifactValue = 0;//        ***************
        }

        // /// <summary>
        // /// Gets the artifact's message.
        // /// </summary>
        // /// <returns>The message as a string.</returns>
        // public string SetMessage(){
        //     return _artifact;
        // }
        /// <summary>
        /// Gets the artifact's value.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public string SetValue(string message){//********GetValue was the name before
            return _artifact;
        }
        
        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        // public void SetMessage(string message)
        // {
        //     _artifact = message;
        // }

        /// <summary>
        /// Sets the artifact's value to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        public void GetValue(int value)
        {
            _artifactValue = value;
        }

        /// <summary>
        /// Checks if actor is a bomb or not
        /// </summary>
        // public void IsBomb(string message)
        // {
        //     if (message == "0")
        //     {
        //       value = -1;  
        //     }
        //     //return
            
        // }

        // public void IsGem(string message)
        // {
        //     if (message == "*")
        //     {
        //       value = -1;  
        //     }
        //     //return
        // }
       
        
    }
}
