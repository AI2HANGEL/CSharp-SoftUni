List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();
string evenNumbers = "";

while (command != "end")
{
    string[] currentCommand = command.Split(" ");
    string action = currentCommand[0];

    if (action == "Contains")
    {
        int value = int.Parse(currentCommand[1]);
        bool containsValue = numbers.Contains(value);
        Console.WriteLine(containsValue ? "Yes" : "No such number");
    }
    else if (action == "PrintEven")
    {
        evenNumbers = string.Join(" ", numbers.Where(n => n % 2 == 0));
    }
    else if (action == "PrintOdd")
    {
        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
    }
    else if (action == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (action == "Filter")
    {
        string currentOperator = currentCommand[1];
        int value = int.Parse(currentCommand[2]);

        List<int> filteredNumbers = new List<int>();

        foreach (int number in numbers)
        {
            switch (currentOperator)
            {
                case "<":
                    if (number < value)
                    {
                        filteredNumbers.Add(number);
                    }
                    break;
                case ">":
                    if (number > value)
                    {
                        filteredNumbers.Add(number);
                    }
                    break;
                case "<=":
                    if (number <= value)
                    {
                        filteredNumbers.Add(number);
                    }
                    break;
                case ">=":
                    if (number >= value)
                    {
                        filteredNumbers.Add(number);
                    }
                    break;
            }
        }

        numbers = filteredNumbers;
    }

    command = Console.ReadLine();
}

if (!string.IsNullOrEmpty(evenNumbers))
{
    Console.WriteLine(evenNumbers);
}
Console.WriteLine(string.Join(" ", numbers));
