List<int> lst = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

while (lst.Count > 2)
{
    lst.RemoveAt(lst.Count - 1);
    lst.RemoveAt(0);
}

Console.WriteLine($"{lst.Average():F2}");