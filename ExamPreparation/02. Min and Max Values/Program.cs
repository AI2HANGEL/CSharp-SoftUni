//List<int> lst = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
//int count = int.Parse(Console.ReadLine());

//List<int> listNew = new List<int>();

//for (int i = 0; i < count; i++)
//{
//    listNew.Add(lst[i]);
//}

//Console.WriteLine(listNew.Max());
//Console.WriteLine(listNew.Min());



List<int> lst = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int count = int.Parse(Console.ReadLine());


while (lst.Count <= count)
{
    lst.RemoveAt(lst.Count - 1);
}

Console.WriteLine(lst.Max());
Console.WriteLine(lst.Min());