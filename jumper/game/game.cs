class game{


    public void startGame(){

        Console.WriteLine("Welcome to Jumper!!!!!!!!!!");
        this.WriteLetters();
        
    }
    
    public void Array(){
        string[] cars = {"  _____", @" /_____\", @" \     /", @"  \   /", "    O", @"   /|\", @"   / \","","^^^^^^^^^"};

        foreach(string i in cars){
            Console.WriteLine(i);
        }
    }

    public string listWords(){
        string[] word = {"robot", "hello"};
        Random random = new Random();
        var idx = new Random().Next(0,word.Length);
        return word[idx];
    }

    public void WriteLetters(){
        string mysteryWord = listWords();
        char[] guess = new char[mysteryWord.Length];
        for (int p = 0; p < mysteryWord.Length; p++)
            guess[p] = '_';  

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine(guess);
            Console.WriteLine("");
            this.Array();
            Console.Write("Guess a letter [a-z] ");
            Console.WriteLine("");
            char playerGuess = char.Parse(Console.ReadLine());
            for (int j = 0; j < mysteryWord.Length; j++)
            {
                if (playerGuess == mysteryWord[j])
                    guess[j] = playerGuess;
            }
        }
    }
};