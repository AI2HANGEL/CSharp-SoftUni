public class MainCourseMenuItem : MenuItem
{
    // Additional properties or methods specific to MainCourseMenuItem can be added here

    // Constructor
    public MainCourseMenuItem(string name, string description, decimal price)
        : base(name, description, price)
    {
        // Additional initialization for MainCourseMenuItem if needed
    }

    // Override ToString() method
    public override string ToString()
    {
        return $"Main Course: {base.ToString()}";
    }
}
