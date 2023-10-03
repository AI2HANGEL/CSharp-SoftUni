int number_n = int.Parse(Console.ReadLine());
var sum = 0.0;

for (int i = 1; i <= number_n; i++)
{
    double num = double.Parse(Console.ReadLine());
    sum += num;
}

Console.WriteLine(sum);