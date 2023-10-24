List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int longestStart = 0;
int longestLength = 1;
int currentStart = 0;
int currentLength = 1;

for (int i = 1; i < numbers.Count; i++)
{
    if (numbers[i] == numbers[i - 1])
    {
        currentLength++;

        if (currentLength > longestLength)
        {
            longestLength = currentLength;
            longestStart = currentStart;
        }
    }
    else
    {
        currentStart = i;
        currentLength = 1;
    }
}

int[] longestSequence = new int[longestLength];
numbers.CopyTo(longestStart, longestSequence, 0, longestLength);

Console.WriteLine(string.Join(" ", longestSequence));