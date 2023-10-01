
int maxnum = int.MinValue;

for (int i = 0; i < 5; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number > maxnum)
    {  maxnum = number; }
}

Console.WriteLine(maxnum);
