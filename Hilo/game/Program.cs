public class Player
{
    Deck deck;
    int score;
    int Card;
    int nextCard;

    public Player()
    {
        this.score = 300;
        this.deck = new Deck();
        Card = this.deck.RandomNumber();
    }

    public void Start()
    {
        string choice = "";
        bool keepPlaying = true;
        string player = "";

        Console.WriteLine("Hello! This is Hilo.");
        Console.WriteLine("What is the name of player?");
        player = Console.ReadLine();
        Console.WriteLine($"Nice name {player}. Let's play!");
        Console.WriteLine();

        while (keepPlaying)
        {
            Console.WriteLine($"The card is: {Card}");
            choice = this.Hilo(choice);

            nextCard = this.NextCard(nextCard);

            score = this.Points(choice, nextCard, Card);

            Console.WriteLine($"Your score is {score}");

            if (score >= 1000)
            {
                keepPlaying = false;
                Console.WriteLine($"You won the game {player}!");
                break;
            }

            if (score <= 0)
            {
                keepPlaying = false;
                Console.WriteLine($"{player}, you just lost a pretty easy game!");
                break;
            }

            Console.WriteLine("Play again? [y/n]");
            string answer = Console.ReadLine();
            Console.WriteLine();

            if (answer == "N" || answer == "n")
            {
                keepPlaying = false;
                Console.WriteLine("GAME OVER!");
                Console.WriteLine($"Thanks for playing {player}!");
            }

            Card = nextCard;
        }
    }


    public string Hilo(string choice)
    {
        Console.Write("Higher or lower? [h/l]");
        choice = Console.ReadLine();
        return choice;
    }

    public int NextCard(int nextcard)
    {
        nextCard = this.deck.RandomNumber();
        Console.WriteLine($"Next card was: {nextCard}");

        return nextCard;
    }

    public int Points(string choice, int nextCard, int Card)
    {
        if (choice == "h" && nextCard > Card)
        {
            score += 100;
        }
        else if (choice == "l" && nextCard < Card)
        {
            score += 100;
        }
        else if (choice == "h" && nextCard < Card)
        {
            score -= 75;
        }
        else if (choice == "l" && nextCard > Card)
        {
            score -= 75;
        }

        return score;
    }
}

