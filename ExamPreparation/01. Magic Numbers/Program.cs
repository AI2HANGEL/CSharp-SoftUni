bool IsPrime(int n)
{
    if (n <= 1)
    {
        return false;
    }
    if (n <= 3)
    {
        return true;
    }
    if (n % 2 == 0 || n % 3 == 0)
    {
        return false;
    }

    for (int i = 5; i * i <= n; i += 6)
    {
        if (n % i == 0 || n % (i + 2) == 0)
        {
            return false;
        }
    }

    return true;
}


int number = int.Parse(Console.ReadLine());
List<int> list = new List<int>();

for (int i = 2; i <= number; i++)
{
    bool isMagic = true;
    int temp = i;
    int sum = 0;

    while (temp != 0)
    {
        int digit = temp % 10;

        if (!IsPrime(digit))
        {
            isMagic = false;
            break;
        }

        sum += digit;
        temp = temp / 10;
    }

    if (isMagic && sum % 2 == 0)
    {
        list.Add(i);
    }
}

if (list.Count > 0)
{
    Console.WriteLine(string.Join(" ", list));
}
else
{
    Console.WriteLine("no");
}