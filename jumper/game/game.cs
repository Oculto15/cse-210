class game{


    public void startGame(){

        Console.WriteLine("Welcome to Jumper!!!!!!!!!!");
        this.WriteLetters();
        
    }
    
    public List<string> Array(){
        var list = new List<string>  {"  _____", @" /_____\", @" \     /", @"  \   /", "    O", @"   /|\", @"   / \","","^^^^^^^^^"};

        foreach(string i in list){
            Console.WriteLine(i);
        }
        return list;
    }

    public string listWords(){
        string[] word = {"robot", "hello"};
        Random random = new Random();
        var idx = new Random().Next(0,word.Length);
        return word[idx];
    }

    public void WriteLetters(){
        string mysteryWord = listWords();
       var list = Array();
        char[] guess = new char[mysteryWord.Length];
        for (int p = 0; p < mysteryWord.Length; p++)
            guess[p] = '_';  

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine(guess);
            Console.WriteLine("");
            this.Array();
            Console.Write("Guess a letter [a-z] "); Console.ReadLine();
            Console.WriteLine("");
            char playerGuess = char.Parse(Console.ReadLine());
            for (int j = 0; j < mysteryWord.Length; j++)
            {
                if (playerGuess == mysteryWord[j]){
                    guess[j] = playerGuess;
                }
                if (playerGuess != mysteryWord[j]){
                    list.RemoveAt(0);
                }
            }
        }
    }

};