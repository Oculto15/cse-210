
VendingMachhine v = new VendingMachhine();
v.Populate();
v.getList();


public class Item{

    private string name;
    private double price;
    private string location;
    private int quantity;


    public Item(string name, double price, string location, int quantity = 1){
        this.name = name;
        this.price = price;
        this.location = location;
        this.quantity = 1;
    }

    private double totalValue(){
        return quantity * price;
    }

    public void showItem(){
        Console.WriteLine($"{name} - {price} - {location} QTY:{quantity}");
        Console.WriteLine($"Total Value: {totalValue()}");
    }
}

public class VendingMachhine{

    private List<Item> items = new List<Item>();
    public VendingMachhine(){
        Console.WriteLine("I am a vending machine");
    }   

    public void Populate(){
        items.Add(new Item("1.Cool Ranch Doritos", 2.5, "A1"));
        items.Add(new Item("2.Reeses", .75, "B3"));
        items.Add(new Item("3.Crystal Litet", 5.00, "C4"));
    }

    public void getList(){
        Console.WriteLine("Items in the vending machine:");
        Console.WriteLine();
        foreach(Item item in items){
           item.showItem();
       }
    }

}