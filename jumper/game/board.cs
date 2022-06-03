public class Board
{

    public List<string> Array()
    {
        var list = new List<string> { "  _____", @" /_____\", @" \     /", @"  \   /", "    O", @"   /|\", @"   / \", "", "^^^^^^^^^" };

        return list;
    }

    public void Draw(List<string> list){
         foreach (string i in list)
        {
            Console.WriteLine(i);
        }
    }

    public int numList(){
        return this.Array().Count;
    }

}




            // List<char> blankSpaces = new List<char>();

// if (mysteryWord.Contains(playerGuess))
            // {
            //     for (int i = 0; i < mysteryWord.Length; i++)
            //     {
            //         if (mysteryWord[i] == playerGuess)
            //         {
            //             blankSpaces[i] = playerGuess;
            //         }

            //         if (!blankSpaces.Contains('_'))
            //         {
            //             board.Draw(this.array);
            //             foreach (char item in blankSpaces)
            //             {
            //                 Console.Write(item);
            //             }
            //             Console.WriteLine();
            //             Console.WriteLine();
            //             Console.WriteLine("Congratulations! You won");
            //             return;

            //         }
            //     }
                
            // }