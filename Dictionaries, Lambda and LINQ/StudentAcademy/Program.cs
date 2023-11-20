int n = int.Parse(Console.ReadLine());

Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(name))
    {
        students[name] = new List<double>();
    }

    students[name].Add(grade);
}

foreach (var pair in students.Where(s => s.Value.Average() >= 4.50))
{
    string name = pair.Key;
    double averageGrade = pair.Value.Average();

    Console.WriteLine($"{name} -> {averageGrade:F2}");
}