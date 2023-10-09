while (true)
{
    string destination = Console.ReadLine();
    if (destination == "End" )
        {
        break;
    }
    int cost = int.Parse(Console.ReadLine());
    int collected = 0;
    while (true)
    {
        int income = int.Parse(Console.ReadLine());
        collected += income;
        Console.WriteLine($"Collected: {collected:F2}");

        if (collected >= cost)
        {
            Console.WriteLine($"Going to {destination}!");
            break;
        }
    }
    
}

