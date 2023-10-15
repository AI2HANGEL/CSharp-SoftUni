
char StartLetter = char.Parse(Console.ReadLine());
char EndLetter = char.Parse(Console.ReadLine());
char ExclLetter = char.Parse(Console.ReadLine());
int counter = 0;

for (char i  = StartLetter; i <= EndLetter; i++)
{
    for (char j = StartLetter; j <= EndLetter; j++)
    {
        for (char k = StartLetter; k <= EndLetter; k++)
        {
            if (j != ExclLetter && i != ExclLetter && k != ExclLetter)
            {
                Console.Write($"{i}{j}{k} ");
                counter += 1;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine(counter);