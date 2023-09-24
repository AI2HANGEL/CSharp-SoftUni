using System;

class Program
{
    static void Main()
    {
 
        int number_a = int.Parse(Console.ReadLine());

        int number_b = int.Parse(Console.ReadLine());

        for (int current_number = number_a; current_number <= number_b; current_number++)
        {
            int sum_even = 0;
            int sum_odd = 0;
            string current_number_as_string = current_number.ToString();

            for (int index = 0; index < current_number_as_string.Length; index++)
            {
                int digit = int.Parse(current_number_as_string[index].ToString());

                if (index % 2 == 0)
                {
                    sum_odd += digit;
                }
                else
                {
                    sum_even += digit;
                }
            }

            if (sum_odd == sum_even)
            {
                Console.Write(current_number + " ");
            }
        }
    }
}
