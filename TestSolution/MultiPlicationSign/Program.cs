static void CheckSign(int a, int b, int c)
{
    int negativeCount = 0;

    if (a < 0)
    {
        negativeCount++;
    }
    if (b < 0)
    {
        negativeCount++;
    }
    if (c < 0)
    {
        negativeCount++;
    }

    if (negativeCount % 2 == 0)
    {
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("zero");
        }
        else
        {
            Console.WriteLine("positive");
        }
    }
    else
    {
        Console.WriteLine("negative");
    }
}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

CheckSign(num1, num2, num3);
