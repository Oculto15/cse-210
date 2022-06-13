public class Director{

    Player playerone = new Player();
    Player playertwo = new Player();
    Rules r = new Rules();
    bool GameOver = false;



    public Director(){
        // StartGame();
    }

    public void StartGame(){
        while(!GameOver){
        GetInputs();
        DoUpdates();
        GetOutputs();
        }
    }

    public void GetInputs(){
        playerone.makeChoice();
        playertwo.makeChoice();

    }
    public void DoUpdates(){
        int winner = r.WhoWins(playerone.getChoice(),playertwo.getChoice());
        Console.WriteLine($"{playerone.getChoice()} vs {playertwo.getChoice()}");
        if(winner == 1){
            Console.WriteLine("Player One won this round");
            playerone.Win();
        }
        else if(winner == 2){
            Console.WriteLine("Player Two won this round");
            playertwo.Win();
        }
        else {
            Console.WriteLine("Tied");
        }
    }
    public void GetOutputs(){
        Console.WriteLine($"Player 1 Wins: {playerone.getWins()}\nPlayer 2 Wins: {playertwo.getWins()}");
        if(playerone.getWins()>=5){
            Console.WriteLine("Player One wins");
            GameOver = true;
        }
        if(playertwo.getWins()>=5){
            Console.WriteLine("Player Two wins");
            GameOver = true;
        }
    }

}