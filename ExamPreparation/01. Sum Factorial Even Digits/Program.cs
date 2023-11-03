static int CalculateFactorial(int num)
{
    int result = 1;
    while (num > 0)
    {
        result *= num;
        num--;
    }
    return result;

}

int number = int.Parse(Console.ReadLine());
int sum = 0;

while (number != 0)
{
    int digit = number % 10;
    if (digit % 2 == 0)
    {
        int resultFact = CalculateFactorial(digit);
        sum += resultFact;
    }
    number = number / 10;
}

Console.WriteLine(sum);