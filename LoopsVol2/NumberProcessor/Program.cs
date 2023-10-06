int reading_initial_number_from_input = int.Parse(Console.ReadLine());

while (true)
{
    string command = Console.ReadLine();
    
    if (command == "End")
    {
        break;

    }
    else if (command == "Inc")
    {
        reading_initial_number_from_input ++;
    }
    else if (command == "Dec")
    {
        reading_initial_number_from_input --;
    }
}

Console.WriteLine(reading_initial_number_from_input);