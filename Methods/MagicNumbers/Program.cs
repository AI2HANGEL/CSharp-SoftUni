int magicNumber = int.Parse(Console.ReadLine());

for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        for (int k = 1; k < 10; k++)
        {
            if (i * j * k == magicNumber)
            {
                Console.Write($"{i}{j}{k} ");
            }
        }

    }

}
