static long CalculateFactorial(int n)
{
    long result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

int numbA = int.Parse(Console.ReadLine());
int numbB = int.Parse(Console.ReadLine());

long result = CalculateFactorial(numbA) / CalculateFactorial(numbB);
Console.WriteLine(result);
