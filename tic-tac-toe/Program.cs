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
        Console.ReadLine();
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

                turn = Win();

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
            
            if (turn == false){
                Console.WriteLine("It's a draw!");
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
        if (list[1] == "O" && list[2] == "O" && list[3] == "O")
        {
            return true;
        }
        else if (list[4] == "O" && list[5] == "O" && list[6] == "O")
        {
            return true;
        }
        else if (list[7] == "O" && list[8] == "O" && list[9] == "O")
        {
            return true;
        }
        else if (list[1] == "O" && list[5] == "O" && list[9] == "O")
        {
            return true;
        }
        else if (list[7] == "O" && list[5] == "O" && list[3] == "O")
        {
            return true;
        }
        else if (list[1] == "O" && list[4] == "O" && list[7] == "O")
        {
            return true;
        }
        else if (list[2] == "O" && list[5] == "O" && list[8] == "O")
        {
            return true;
        }
        else if (list[3] == "O" && list[6] == "O" && list[9] == "O")
        {
            return true;
        }
        else if (list[1] == "X" && list[2] == "X" && list[3] == "X")
        {
            return true;
        }
        else if (list[4] == "X" && list[5] == "X" && list[6] == "X")
        {
            return true;
        }
        else if (list[7] == "X" && list[8] == "X" && list[9] == "X")
        {
            return true;
        }
        else if (list[1] == "X" && list[5] == "X" && list[9] == "X")
        {
            return true;
        }
        else if (list[7] == "X" && list[5] == "X" && list[3] == "X")
        {
            return true;
        }
        else if (list[1] == "X" && list[4] == "X" && list[7] == "X")
        {
            return true;
        }
        else if (list[2] == "X" && list[5] == "X" && list[8] == "X")
        {
            return true;
        }
        else if (list[3] == "X" && list[6] == "X" && list[9] == "X")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}