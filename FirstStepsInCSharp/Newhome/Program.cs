string typeofflower = Console.ReadLine();
int flowercount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double sum = 0;

if (typeofflower == "Roses")
{
    sum = 5 * flowercount;
    if (flowercount > 80)
    {
        sum = sum * 0.9;
    }
}
else if (typeofflower == "Dahlias")
{
    sum = 3.8 * flowercount;
    if (flowercount > 90)
    {
        sum = sum * 0.85;
    }
}
else if (typeofflower == "Tulips")
{
    sum = 2.8 * flowercount;
    if (flowercount > 80)
    {
        sum = sum * 0.85;
    }
}
else if (typeofflower == "Narcissus")
{
    sum = 3 * flowercount;
    if (flowercount < 120)
    {
        sum = sum * 1.15;
    }
}
else if (typeofflower == "Gladiolus")
{
    sum = 2.5 * flowercount;
    if (flowercount < 80)
    {
        sum = sum * 1.2;
    }
}

double neededmoney = Math.Abs(sum - budget);
if (sum <= budget)
{
    Console.WriteLine($"Hey, you have a great garden with {flowercount} {typeofflower} and {neededmoney:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {neededmoney:F2} leva more.");
}