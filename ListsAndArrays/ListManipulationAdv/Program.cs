List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] currentCommand = command.Split(" ");
    string action = currentCommand[0];


    if (action == "Contains")

    {
        int value = int.Parse(currentCommand[1]);
        foreach (int number in numbers)
        {
            if (number == value)
            {
                Console.WriteLine("Yes");
                break;
            }
            else
            {
                Console.WriteLine("No such number");
                break;
                
            }
        }
    }
    else if (action == "PrintEven")
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
                break;

            }
        }
    }
    else if (action == "PrintOdd")
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
                break;

            }
        }
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
    } Console.WriteLine(string.Join(" ", numbers));




    command = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine(string.Join(" ", numbers));