int amount = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < amount; i++)
{
    string vowel = Console.ReadLine();
    
    switch (vowel)
    {
        case "a": sum += 1; break;
        case "e": sum += 2; break;
        case "i": sum += 3; break;
        case "o": sum += 4; break;
        case "u": sum += 5; break;
        default: continue;
        
    }
   
}
Console.WriteLine(sum);