using System;

class Program
{
    static void Main()
    {
        string movie_title = Console.ReadLine();
        int counter_standard = 0;
        int counter_kid = 0;
        int counter_student = 0;

        while (movie_title != "Finish")
        {
            int available_seats = int.Parse(Console.ReadLine());
            int sold_seats = 0;

            for (int tickets = 0; tickets < available_seats; tickets++)
            {
                string current_ticket = Console.ReadLine();

                if (current_ticket == "End")
                {
                    break;
                }
                else if (current_ticket == "student")
                {
                    counter_student++;
                }
                else if (current_ticket == "standard")
                {
                    counter_standard++;
                }
                else if (current_ticket == "kid")
                {
                    counter_kid++;
                }

                sold_seats++;
            }

            double percent_full_hall = (double)sold_seats / available_seats * 100;
            Console.WriteLine($"{movie_title} - {percent_full_hall:F2}% full.");

            movie_title = Console.ReadLine();
        }

        int total_tickets = counter_student + counter_standard + counter_kid;
        Console.WriteLine($"Total tickets: {total_tickets}");

        double percent_student_tk = (double)counter_student / total_tickets * 100;
        Console.WriteLine($"{percent_student_tk:F2}% student tickets.");

        double percent_standard_tk = (double)counter_standard / total_tickets * 100;
        Console.WriteLine($"{percent_standard_tk:F2}% standard tickets.");

        double percent_kid_tk = (double)counter_kid / total_tickets * 100;
        Console.WriteLine($"{percent_kid_tk:F2}% kids tickets.");
    }
}
