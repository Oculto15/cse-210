public class Deck {
    public int card;
    
    public Deck() {
    }
    
    public int RandomNumber() {
        Random random = new Random();
        card = random.Next(0, 13);

        return card;
    }
}