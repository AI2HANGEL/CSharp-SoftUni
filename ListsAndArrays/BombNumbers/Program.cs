List<int> numberSequence = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> bombNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();



int bombnumber = bombNumbers[0];
int power = bombNumbers[1];

List<int> filteredSequence = new List<int>(numberSequence);

for (int i = 0; i < filteredSequence.Count; i++)
{
    if (filteredSequence[i] == bombnumber)
    {
        int startIndex = Math.Max(0, i - power);
        int endIndex = Math.Min(filteredSequence.Count - 1, i + power);

        filteredSequence.RemoveRange(startIndex, endIndex - startIndex + 1);
        i = startIndex - 1; 
    }
}

int sum = filteredSequence.Sum();

Console.WriteLine(sum);
