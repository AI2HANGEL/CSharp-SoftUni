int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int num = start; num <= end; num++)
{
    bool isPrime = true;
    int divider = 2;

    while (divider * divider <= num)
    {
        if (num % divider == 0)
        {
            isPrime = false;
            break;
        }
        divider++;
    }

    if (isPrime)
    {
        Console.Write($"{num} ");
    }
}
