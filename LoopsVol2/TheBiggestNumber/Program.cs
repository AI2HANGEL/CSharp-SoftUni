int amount_nums = int.Parse(Console.ReadLine());
int max_num = int.MinValue;
for (int i = 0; i < amount_nums; i++)
{
    int current_num = int.Parse(Console.ReadLine());
    if (current_num > max_num)
    {
        max_num = current_num;
    }
}
Console.WriteLine(max_num);