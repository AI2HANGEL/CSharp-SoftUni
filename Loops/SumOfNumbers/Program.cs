
int number_n = int.Parse(Console.ReadLine());
int sum_of_num = 0;

while  (true)
{
    int new_num = int.Parse(Console.ReadLine());
    sum_of_num += new_num;
    if (sum_of_num >= number_n)
        break;

}
Console.WriteLine(sum_of_num);