List<Box> boxes = new List<Box>();

while (true)
{
    string[] command = Console.ReadLine().Split(" ");

    if (command[0] == "end")
    {
        break;
    }

    string serialNumber = command[0];
    string itemName = command[1];
    int itemQuantity = int.Parse(command[2]);
    decimal itemPrice = decimal.Parse(command[3]); ;

    Item currentItem = new Item(itemName, itemPrice);
    Box currentBox = new Box(serialNumber, currentItem, itemQuantity);

    boxes.Add(currentBox);

}

boxes = boxes.OrderByDescending(box => box.PriceForBox).ToList();

foreach (Box box in boxes)
{
    Console.WriteLine($"{box.SerialNumber}");
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceForBox:F2}");
}


public class Item
{
    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }

    public decimal Price { get; set; } 
}

public class Box
{
    public Box(string serialNumber, Item item, int itemQuantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        PriceForBox = item.Price * itemQuantity;

    }
    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public decimal PriceForBox { get; set; } 
}
