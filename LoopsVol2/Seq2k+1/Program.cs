int numb = int.Parse(Console.ReadLine());
int current_numb = 1;

while (current_numb <= numb)
{
    Console.WriteLine(current_numb);
    current_numb = 2 * current_numb + 1;
}


