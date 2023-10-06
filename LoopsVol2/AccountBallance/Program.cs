//double balance = 0;

//while (true)
//{
//    string command = Console.ReadLine();

//    if (command == "End")
//    {
//        break;
//    }

//    double number = double.Parse(command);
//    string action = (number > 0) ? "Increase" : "Decrease";
//    Console.WriteLine($"{action}: {Math.Abs(number):F2}");
//    balance += number;
//}

//Console.WriteLine($"Balance: {balance:F2}");


double ballance = 0;

while (true)
{
    string command = Console.ReadLine();

    if (command == "End")
    {
        break;
    }

    else
    {
        double number = double.Parse(command);
        if (number > 0)
        {
            Console.WriteLine($"Increase: {number:F2}");
            ballance += number;
        }
        else
        {
            Console.WriteLine($"Decrease: {Math.Abs(number):F2}");
            ballance += number;
        }


    }
}
Console.WriteLine($"Balance: {ballance:F2}");