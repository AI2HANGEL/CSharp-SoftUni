
int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());
int result = 0;

for  (int i = 1; i < power; i++)
{
    if (result == 0)
    {
        result = number * number;
    }
    else
    {
        result *= number;
    }
}
Console.WriteLine(result);