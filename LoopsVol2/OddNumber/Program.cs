while (true)
{
    int numb = int.Parse(Console.ReadLine());

    if (numb % 2 != 0)
    {
        Console.WriteLine(numb);
        break;
    }
}