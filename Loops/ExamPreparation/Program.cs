int maxlowgrades = int.Parse(Console.ReadLine());
double grade_sum = 0; //This is in order to get accurate division and result
int problem_counter = 0;
int fails = 0;
string lstProb = "";
bool isfailed = false;


while (true)
{

    string ProblemName = Console.ReadLine();
    if (ProblemName == "Enough")
    {
        break;
    }

    int Grade = int.Parse(Console.ReadLine());

    if (Grade <= 4)
    {
        fails++;
        if (fails == maxlowgrades)
        {
            isfailed = true;
            break;
        }
    }

    lstProb = ProblemName;
    problem_counter++;
    grade_sum += Grade;


}
double avg_grade = grade_sum / problem_counter;
if (isfailed)
{
    Console.WriteLine($"You need a break, {fails} poor grades.");
}

else
{
    Console.WriteLine($"Average score: {avg_grade:F2}");
    Console.WriteLine($"Number of problems: {problem_counter}");
    Console.WriteLine($"Last problem: {lstProb}");

}