
static void CheckPosition(int[] arrOne, int[] arrTwo, int counterArr, int i, int[] currentArray)
{
    if (counterArr % 2 != 0)
    {
        arrOne[i] = currentArray[0];
        arrTwo[i] = currentArray[1];
    }
    else
    {
        arrOne[i] = currentArray[1];
        arrTwo[i] = currentArray[0];
    }
}



int number = int.Parse(Console.ReadLine());


int[] arrOne = new int[number];
int[] arrTwo = new int[number];

int counterArr = 0;

for (int i = 0; i < number; i++)
{
    int[] currentArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    counterArr++;

    CheckPosition(arrOne, arrTwo, counterArr, i, currentArray);

}

Console.WriteLine(string.Join(" ", arrOne));    
Console.WriteLine(string.Join(" ", arrTwo));    