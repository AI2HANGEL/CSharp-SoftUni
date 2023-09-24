int jury_numbers = int.Parse(Console.ReadLine());

string command = Console.ReadLine();
double grades_sum = 0;
double final_grade_sum = 0;
int assesment = 0;

while (command != "Finish")
{
    string presentation_name = command;
    for (int i = 0; i < jury_numbers; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        grades_sum += grade;

    }
    double avg_grade = grades_sum / jury_numbers;
    Console.WriteLine($"{presentation_name} - {avg_grade:F2}.");

    final_grade_sum += avg_grade;
    assesment++;
    grades_sum = 0;
    command = Console.ReadLine();
}

double grade_total = final_grade_sum / assesment;
Console.WriteLine($"Student's final assessment is {grade_total:F2}.");
