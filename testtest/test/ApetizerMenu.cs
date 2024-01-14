public class AppetizerMenuItem : MenuItem
{
    // Additional properties or methods specific to AppetizerMenuItem can be added here

    // Constructor
    public AppetizerMenuItem(string name, string description, decimal price)
        : base(name, description, price)
    {
        // Additional initialization for AppetizerMenuItem if needed
    }

    // Override ToString() method
    public override string ToString()
    {
        return $"Appetizer: {base.ToString()}";
    }
}
