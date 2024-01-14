public abstract class MenuItem
{
    // Properties
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    // Constructor
    public MenuItem(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }

    // Method to override ToString()
    public override string ToString()
    {
        return $"{Name} - {Description} - ${Price}";
    }
}
