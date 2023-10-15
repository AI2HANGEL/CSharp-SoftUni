static int CalculateEvenOddProduct(int number)
{
    int evenSum = 0;
    int oddSum = 0;

    while (number > 0)
    {
        int digit = number % 10;

        if (digit % 2 == 0)
        {
            evenSum += digit;
        }
        else
        {
            oddSum += digit;
        }

        number = number / 10;
    }

    return evenSum * oddSum;
}

int number = (int)Math.Abs(int.Parse(Console.ReadLine()));

int result = CalculateEvenOddProduct(number);

Console.WriteLine(result);
