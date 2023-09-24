string command = Console.ReadLine();
int minValue = int.MaxValue;

while (command != "Stop")
{
    int current_number = int.Parse(command);
    if (current_number < minValue)
    {
        minValue = current_number;
    }
    command = Console.ReadLine();
}

Console.WriteLine(minValue);