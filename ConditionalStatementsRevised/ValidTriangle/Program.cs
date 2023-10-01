int sideA = int.Parse(Console.ReadLine());
int sideB = int.Parse(Console.ReadLine());
int sideC = int.Parse(Console.ReadLine());

bool isValid = false;


if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
{
    isValid = true;
}


if (isValid)
{
    Console.WriteLine("Valid Triangle");
}
else
{
    Console.WriteLine("Invalid Triangle");
}