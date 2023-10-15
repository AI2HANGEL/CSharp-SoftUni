
static void GeneratePassword(int number)
{
    for (int even = 2; even <= number; even += 2)
    {
        for (int odd = 1; odd <= number; odd += 2)
        {
            Console.Write($"{even}{odd}{even * odd} ");
        }
    }
}
int number = int.Parse(Console.ReadLine());
GeneratePassword(number);