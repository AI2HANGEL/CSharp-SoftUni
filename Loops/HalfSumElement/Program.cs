int numbers = int.Parse(Console.ReadLine());
int maxnum = int.MinValue;
int sum_numbers = 0;


for (int i = 0; i < numbers; i++)
{
    int current_num = int.Parse(Console.ReadLine());
    sum_numbers += current_num;
    if (current_num > maxnum)
    {
        maxnum = current_num;
    }
}

int sumwithoutmax = sum_numbers - maxnum;
if (maxnum == sumwithoutmax)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + maxnum);
}
else
{
    int diff = Math.Abs(maxnum - sumwithoutmax);
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);

}