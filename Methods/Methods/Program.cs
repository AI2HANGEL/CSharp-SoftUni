static void SignOfNumbers(int num)
{
    if (num > 0)
    {
        Console.WriteLine($"The number {num} is positive.");
    }
    else if (num < 0)
    {
        Console.WriteLine($"The number {num} is negative.");
    }
    else if (num == 0)
    {
        Console.WriteLine($"The number {num} is zero.");
    }

}


int number = int.Parse(Console.ReadLine());
SignOfNumbers(number);