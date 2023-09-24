using System;

class Program
{
    static void Main()
    {
        string student_name = Console.ReadLine();
        double grade_sum = 0.0;
        int fail_count = 0;
        int grade = 0;
        double avg_grade = 0;

        while (grade < 12)
        {
            double annual_grade = double.Parse(Console.ReadLine());

            if (annual_grade < 4.00)
            {
                fail_count++;
            }

            if (fail_count >= 2)
            {
                Console.WriteLine($"{student_name} has been excluded at {grade} grade");
                return; 
            }

            grade++;
            grade_sum += annual_grade;
        }

        avg_grade = grade_sum / 12;

        Console.WriteLine($"{student_name} graduated. Average grade: {avg_grade:F2}");
    }
}
