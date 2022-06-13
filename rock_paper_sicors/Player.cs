public class Player {

    private int wins =0;
    private string choice = "";

    public void makeChoice(){
        Console.WriteLine("Please make a selection:\n[R]ock\n[P]aper\n[S]cissors");
        choice = Console.ReadLine();
        choice = choice.ToUpper();
        if(choice != "R" && choice != "P" && choice != "S" ){
            Console.WriteLine("Invalid Choice");
            makeChoice();
        }
    }
    public string getChoice(){
        return choice;
    }
    public void Win(){
        wins += 1;
    }

    public int getWins(){
        return wins;
    }

}