string[] input = Console.ReadLine().Split(" ");

foreach  (string line in input)
{
    if (line.Length % 2 == 0)
    {
        Console.WriteLine(line);
    }
}