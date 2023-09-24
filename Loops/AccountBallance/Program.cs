double total_sum = 0;
while (true)
{
    string command = Console.ReadLine();

    if (command == "NoMoreMoney")
    {
        Console.WriteLine($"Total: {total_sum:F2}");
        break;
    }
    else
    {
        double deposit = double.Parse(command);
        if (deposit >= 0)
        {
            Console.WriteLine($"Increase: {deposit:F2}");
            total_sum += deposit;
        }
        else
        {
            Console.WriteLine("Invalid operation!");
            Console.WriteLine($"Total: {total_sum:F2}");
            break;
        }
    }
        

}