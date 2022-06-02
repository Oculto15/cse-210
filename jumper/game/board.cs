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