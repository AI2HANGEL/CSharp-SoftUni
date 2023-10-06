int stopNumber = int.Parse(Console.ReadLine());
int previousNumber = 0;
double result = 0;

while (true)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber == stopNumber)
    {
        result = previousNumber * 1.2;
        Console.WriteLine(result);
        break;
    }

    previousNumber = currentNumber;
}
