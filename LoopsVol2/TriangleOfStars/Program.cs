int rows = int.Parse(Console.ReadLine());

for (int i = 1; i <= rows; i++)
{
    string symbol = "";
    for (int j = 1; j <= i; j++)
    {
        symbol += "*";
    }
    Console.WriteLine(symbol);
}
