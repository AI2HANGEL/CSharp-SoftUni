string command = Console.ReadLine();
int maxValue = int.MinValue;

while (command != "Stop")
{
    int current_number = int.Parse(command);
    if (current_number > maxValue)
    {
        maxValue = current_number;
    }
    command = Console.ReadLine();
}

Console.WriteLine(maxValue);