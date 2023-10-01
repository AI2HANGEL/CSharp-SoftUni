string movie = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());
var price = 0.0;

if (movie == "Premiere")
{
    price = rows * seats * 12;
}
else if (movie == "Normal")
{
    price = rows * seats * 7.50;

}
else if (movie == "Discount")
{
    price = (rows * seats * 5.00); 
}

Console.WriteLine($"{price:F2}");