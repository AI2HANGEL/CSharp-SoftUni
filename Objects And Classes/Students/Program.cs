
string command = Console.ReadLine();

List<Students> Student = new List<Students>();

while (command != "end")
{
    string[] currentCommand = command.Split(" ");

    string firstName = currentCommand[0];
    string lastName = currentCommand[1];
    int age = int.Parse(currentCommand[2]);
    string town = currentCommand[3];

    Students current = new Students
    {
        FirstName = firstName,
        LastName = lastName,
        Age = age,
        Town = town,

    };
    Student.Add(current);


    command = Console.ReadLine();
}

string requestedTown = Console.ReadLine();

List<Students> filteredStudents = Student.Where(x => x.Town == requestedTown).ToList();

foreach (Students student in filteredStudents)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}

public class Students
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string Town { get; set; }
}