double numA = double.Parse(Console.ReadLine());
double numB = double.Parse(Console.ReadLine());
double numC = double.Parse(Console.ReadLine());

string sign;

if (numA == 0 || numB == 0 || numC == 0)
{
    sign = "zero";

}

else if ((numA > 0 && numB < 0 && numC < 0) || 
    (numA < 0 && numB > 0 && numC < 0) ||
    (numA < 0 && numB < 0 && numC > 0))
{
    sign = "positive";
}
else
{
    sign = "negative";
}

Console.WriteLine(sign);
