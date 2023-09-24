using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int number = 1111; number <= 9999; number++)
        {
            int currentNumber = number;
            bool isSpecial = true;

            while (currentNumber > 0)
            {
                int digit = currentNumber % 10;

                if (digit == 0 || N % digit != 0)
                {
                    isSpecial = false;
                    break;
                }

                currentNumber /= 10;
            }

            if (isSpecial)
            {
                Console.Write(number + " ");
            }
        }
    }
}
