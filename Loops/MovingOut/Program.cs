int apartment_w = int.Parse(Console.ReadLine());
int apartment_l = int.Parse(Console.ReadLine());
int apartment_h = int.Parse(Console.ReadLine());

int total_space = apartment_h * apartment_w * apartment_l;
bool isdone = false;

while (total_space >= 0)
{
    string command = Console.ReadLine();

    if (command == "Done")
    {
        break;
    }

    total_space -= int.Parse(command);
}

if (total_space >= 0)
{
    Console.WriteLine($"{total_space} Cubic meters left.");
   
}
else
{
    Console.WriteLine($"No more free space! You need {Math.Abs(total_space)} Cubic meters more.");
}