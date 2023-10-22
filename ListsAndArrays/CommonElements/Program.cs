static int[] CommonElements(int[] arrOne, int[] arrTwo)
{
    List<int> commonList = new List<int>();
    foreach (int i in arrOne)
    {
        foreach (int j in arrTwo)
        {
            if (i == j)
            {
                commonList.Add(i);
                break;
            }
        }
    }

    return commonList.ToArray();
}
static void ExtractArray(int[] commonElements)
{
    for (int i = 0; i < commonElements.Length; i++)
    {
        Console.Write(commonElements[i]);
        if (i < commonElements.Length - 1)
        {
            Console.Write(" ");
        }
    }
}

int[] firstArray = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int[] secondArray = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();


int[] commonElements = CommonElements(firstArray, secondArray);
ExtractArray(commonElements);

