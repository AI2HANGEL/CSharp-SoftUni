int[] firstArray = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int[] secondArray = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

static bool CompareArrays(int[] arrOne, int[] arrTwo)
{
    for (int i = 0; i < arrOne.Length; i++)
    {
        if (arrOne[i] != arrTwo[i])
        {
            return false;
        }
    }

    return true;
}


bool AreEqual = CompareArrays(firstArray, secondArray);

if (AreEqual)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}