
List<int> lst = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int count = int.Parse(Console.ReadLine());

while (lst.Count > count)
{
    lst.RemoveAt(0);
}

Console.WriteLine($"{lst.Average():F2}");