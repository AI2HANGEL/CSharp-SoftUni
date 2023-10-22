
List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();


string command = Console.ReadLine();

while (command != "end")
{

    string[] commandElements = command.Split(" ");
    string commandName = commandElements[0];
    int value = int.Parse(commandElements[1]);


    if (commandName == "Delete")
    {
        numbers.RemoveAll(number => number == value);
    }

    else if (commandName == "Insert")
    {
        int position = int.Parse(commandElements[2]);
        numbers.Insert(position, value);
        
    }


    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
