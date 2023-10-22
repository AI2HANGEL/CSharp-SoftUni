int numberN = int.Parse(Console.ReadLine());

int[] ints = new int[numberN];


for (int i = 0; i < numberN; i++)
{
    int current = int.Parse((Console.ReadLine()));
    ints[i] = current;
}

for  (int i = numberN - 1; i >= 0; i--)
{
    Console.Write(ints[i] +" ");
}