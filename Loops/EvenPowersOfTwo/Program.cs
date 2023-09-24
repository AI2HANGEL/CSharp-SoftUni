
int number_n = int.Parse(Console.ReadLine());

for (int i = 0; i <= number_n; i += 2)
{
    double result = Math.Pow(2, i);
    Console.WriteLine(result);
}
