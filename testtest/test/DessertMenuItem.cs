public class DessertMenuItem : MenuItem
{
    // Additional properties or methods specific to DessertMenuItem can be added here

    // Constructor
    public DessertMenuItem(string name, string description, decimal price)
        : base(name, description, price)
    {
        // Additional initialization for DessertMenuItem if needed
    }

    // Override ToString() method
    public override string ToString()
    {
        return $"Dessert: {base.ToString()}";
    }
}
