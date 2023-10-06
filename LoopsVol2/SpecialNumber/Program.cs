int number_n = int.Parse(Console.ReadLine());
int originalNumber = number_n;
bool isSpecial = true;

while (number_n > 0)
{
    int digit = number_n % 10;
    if (digit == 0 || originalNumber % digit != 0)
    {
        isSpecial = false;
        break;
    }
    number_n = number_n / 10;
}

if (isSpecial)
{
    Console.WriteLine($"{originalNumber} is special");
}
else
{
    Console.WriteLine($"{originalNumber} is not special");
}
