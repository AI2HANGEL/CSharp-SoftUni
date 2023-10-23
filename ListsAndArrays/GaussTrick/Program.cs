List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

while (numbers.Count > 1)
{
    
    int sum = numbers.First() + numbers.Last();
    Console.Write(sum + " ");

    numbers.Remove(numbers.First());
    numbers.Remove(numbers.Last());

}

if (numbers.Count == 1)
{
    Console.WriteLine(numbers[0]);
}