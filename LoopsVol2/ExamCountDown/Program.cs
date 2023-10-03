int before_Exam = int.Parse(Console.ReadLine());

for (int i = before_Exam; i >= 0; i--) 
{
    if (i == 0)
    {
        Console.WriteLine("The exam has come");
        break;
    }
    Console.WriteLine($"{i} days before the exam");
}