static void PrintTriangle(int N)
{
    // Print the top half of the triangle
    for (int i = 1; i <= N; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }

    // Print the bottom half of the triangle
    for (int i = N - 1; i >= 1; i--)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}

int number = int.Parse(Console.ReadLine());
PrintTriangle(number);