class Program
{

    static List<string> list = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };


    static void DrawBoard()
    {
        Console.WriteLine($" {list[1]} | {list[2]} | {list[3]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {list[4]} | {list[5]} | {list[6]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {list[7]} | {list[8]} | {list[9]} ");
    }

    static void Main(string[] menu)
    {
        string player1 = "", player2 = "";
        int roll = 1, number = 0;
        bool turn = false, playing = true, input = false;

        Console.WriteLine("Hello! This is Tic Tac Toe.");
        Console.WriteLine("What is the name of player 1?");
        player1 = Console.ReadLine();
        Console.WriteLine("What is the name of player 2?");
        player2 = Console.ReadLine();
        Console.WriteLine($"{player1} is O and {player2} is X.");
        Console.WriteLine($"{player1} goes first.");
        Console.Clear();

        while (playing == true)
        {
            while (turn == false)
            {
                DrawBoard();
                Console.WriteLine("");

                if (roll == 1)
                {
                    Console.WriteLine($"{player1}'s (O) turn");
                }
                if (roll == 2)
                {
                    Console.WriteLine($"{player2}'s (X) turn");
                }

                while (input == false)
                {

                    Console.WriteLine("Where will your move be?");
                    number = int.Parse(Console.ReadLine());
                    if (number > 0 && number < 10){
                        input = true;
                    }
                    else{
                        continue;
                    }
                }
                input = false;

                if (roll == 1)
                {
                    if (list[number] == "X")
                    {
                        continue;
                    }
                    else
                    {
                        list[number] = "O";
                    }
                }
                if (roll == 2)
                {
                    if (list[number] == "O")
                    {
                        continue;
                    }
                    else
                    {
                        list[number] = "X";
                    }
                }

                
                turn = Win() || Draw();
                
                if (turn == false)
                {
                    if (roll == 1)
                    {
                        roll = 2;
                    }
                    else if (roll == 2)
                    {
                        roll = 1;
                    }
                    Console.Clear();
                }
            }
            if (Win() == false && Draw() == true){
            Console.WriteLine("It's a draw!");
            break;
            }  
            
           
            if (turn == true)
            {
                if (roll == 1){
                    Console.WriteLine($"{player1} wins!");
                    Console.WriteLine("Thanks for playing!");
                }
                if (roll == 2){
                    Console.WriteLine($"{player2} wins!");
                    Console.WriteLine("Thanks for playing!");
                }
                break;
            }
            
            
        }
    }

    static bool Win()
    {
        if (list[1] == list[2] && list[2] == list[3])
        {
            return true;
        }
        else if (list[4] == list[5] && list[5] == list[6])
        {
            return true;
        }
        else if (list[7] == list[8] && list[8] == list[9])
        {
            return true;
        }
        else if (list[1] == list[5] && list[5] == list[9])
        {
            return true;
        }
        else if (list[7] == list[5] && list[5] == list[3])
        {
            return true;
        }
        else if (list[1] == list[4] && list[4] == list[7])
        {
            return true;
        }
        else if (list[2] == list[5] && list[5] == list[8])
        {
            return true;
        }
        else if (list[3] == list[6] && list[6] == list[9])
        {
            return true;
        }
        else {
            return false;
        }
    }
    static bool Draw()
    {
        if (list[1] != "1" && list[2] != "2"  && list[3] != "3"  && list[4] != "4"  && list[5] != "5"  && list[6] != "6"  && list[7] != "7"  && list[8] != "8"  && list[9] != "9" ){
            return true;
        }
        else {
            return false;
        }
    }
}

