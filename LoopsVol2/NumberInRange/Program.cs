while (true)
{
    int number_n = int.Parse(Console.ReadLine());

    if (number_n >= 1 && number_n <= 100)
    {
        Console.WriteLine(number_n);
        break;
    }
}