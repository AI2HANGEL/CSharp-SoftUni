List<int> ArrayNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int rotations = int.Parse(Console.ReadLine());


for (int i = 0; i < rotations; i++)
{
    int currentNum = ArrayNumbers[0];

    ArrayNumbers.Remove(ArrayNumbers[0]);
    ArrayNumbers.Add(currentNum);
}

Console.WriteLine(string.Join(" ", ArrayNumbers));