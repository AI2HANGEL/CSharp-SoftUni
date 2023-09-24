using System;

class Program
{
    static void Main()
    {
        int primeSum = 0;
        int nonPrimeSum = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "stop")
                break;

            if (int.TryParse(input, out int number))
            {
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int divisors = 0;

                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            divisors++;
                        }
                    }

                    if (divisors == 2)
                    {
                        primeSum += number;
                    }
                    else
                    {
                        nonPrimeSum += number;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
        Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
    }
}
