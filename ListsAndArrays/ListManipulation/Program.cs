List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] currentCommand = command.Split(" ");
    string action = currentCommand[0];
    int value = int.Parse(currentCommand[1]);

    if (action == "Add")
    {
        numbers.Add(value);
    }
    else if (action == "Remove")
    {
        numbers.Remove(value);
    }
    else if (action == "RemoveAt")
    {
        numbers.RemoveAt(value);
    }
    else if (action == "Insert")
    {
        int position = int.Parse(currentCommand[2]);
        numbers.Insert(position, value);
    }



    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));