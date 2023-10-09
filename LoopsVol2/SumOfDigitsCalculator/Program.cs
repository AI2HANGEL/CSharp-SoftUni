string command = Console.ReadLine();

while (command != "End")
{
    int number = int.Parse(command);
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number = number / 10;
    }
    Console.WriteLine($"Sum of digits = {sum}");


    command = Console.ReadLine();

}
Console.WriteLine("Goodbye");