int starting_number = int.Parse(Console.ReadLine());
int current_number = 1;

while (current_number <= starting_number)
{
    Console.WriteLine(current_number);
    current_number = current_number * 2 + 1;
}
