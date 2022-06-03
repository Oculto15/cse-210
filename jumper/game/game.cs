class game{

    List<string> array;
    Board board; 
    int count;

    public game() {
        board = new Board();
        this.array = board.Array();
        count = board.numList();
        
    }

    public void startGame(){

        Console.WriteLine("Welcome to Jumper!!!!!!!!!!");
        this.WriteLetters();  
    }
    
   

    public string listWords(){
        string[] word = {"robot", "hello", "details", "jumper", "wallet", "catdog", "pencil", "bagpack"};
        Random random = new Random();
        var idx = new Random().Next(0,word.Length);
        return word[idx];
    }

    public void WriteLetters(){
        string mysteryWord = listWords();
        var list = this.array;
        char[] guess = new char[mysteryWord.Length];
        for (int p = 0; p < mysteryWord.Length; p++)
            guess[p] = '_';  

        while (count > 5)
        {
            Console.WriteLine("");
            Console.WriteLine(guess);
            Console.WriteLine("");
            board.Draw(this.array);
            Console.Write("Guess a letter [a-z] "); 
            char playerGuess = char.Parse(Console.ReadLine());
            Console.WriteLine("");

            List<int> blankSpaces = new List<int>();
            
            for (int j = 0; j < mysteryWord.Length; j++)
            {
                if (playerGuess == mysteryWord[j]){
                    guess[j] = playerGuess;
                }

            }

            if (!mysteryWord.Contains(playerGuess)){
                    list.RemoveAt(0);
                }
            
            count = this.array.Count;


            // for (int j = 0; j < mysteryWord.Length; j++){
            //     blankSpaces.Add(j);

            //     int listLenght = blankSpaces.Count;
                
            //     if (count == listLenght){
            //         Console.WriteLine("You win!");
            //     }
            // }

        }
    
            this.array[0] = "    x";
            board.Draw(this.array);
            Console.WriteLine("You lose the game!");
        
        
    }
    

};