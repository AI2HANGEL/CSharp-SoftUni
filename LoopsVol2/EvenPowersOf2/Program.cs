
int number = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 0; i <= number; i++)
{
    if (i % 2 == 0)
    {
        result = (int)Math.Pow(2, i);
        Console.WriteLine(result);
    }
    
   
}
