List<int> numberSeqOne = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> numberSeqTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToList();



List<int> mergedList = MergeLists(numberSeqOne, numberSeqTwo);
Console.WriteLine(string.Join(" ", mergedList));



static List<int> MergeLists(List<int> list1, List<int> list2)
{
    List<int> mergedList = new List<int>();

    int maxLength = Math.Max(list1.Count, list2.Count);

    for (int i = 0; i < maxLength; i++)
    {
        if (i < list1.Count)
        {
            mergedList.Add(list1[i]);
        }

        if (i < list2.Count)
        {
            mergedList.Add(list2[i]);
        }
    }

    return mergedList;
}