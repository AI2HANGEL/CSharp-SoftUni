List<int> NumberSequence = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

bool foundAdjacentEqualNumbers = true;

while (foundAdjacentEqualNumbers)
{
    foundAdjacentEqualNumbers = false;

    for (int i = 0; i < NumberSequence.Count - 1; i++)
    {
        if (NumberSequence[i] == NumberSequence[i + 1])
        {
            int sum = NumberSequence[i] + NumberSequence[i + 1];
            NumberSequence[i] = sum;
            NumberSequence.RemoveAt(i + 1);
            foundAdjacentEqualNumbers = true;
        }
    }
}

Console.WriteLine(string.Join(" ", NumberSequence));
