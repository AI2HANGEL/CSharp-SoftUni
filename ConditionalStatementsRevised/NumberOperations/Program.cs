double numA = double.Parse(Console.ReadLine());
double numB = double.Parse(Console.ReadLine());
string opertor = Console.ReadLine();
double result = 0.0;

if (opertor == "+")
{
    result = numA + numB;
}
else if (opertor == "-")
{
    result = numA - numB;
}
else if (opertor == "*")
{
    result = numA * numB;
}
else if (opertor == "/")
{
    result = numA / numB;
}

Console.WriteLine($"{numA} {opertor} {numB} = {result:F2}");