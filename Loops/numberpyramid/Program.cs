int number = int.Parse(Console.ReadLine());
int counter = 1;
bool allPrinted = false;

for (int row = 1; row <= number; row++)
{
    for (int column = 1; column <= row; column++)
    {
        Console.Write(counter + " ");
        counter++;

        if (counter > number)
        {
            allPrinted = true;
            break;
        }
    }

    if (allPrinted)
    {
        break;
    }

    Console.WriteLine();
}

