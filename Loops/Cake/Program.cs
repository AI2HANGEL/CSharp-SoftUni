using System.Security.Cryptography.X509Certificates;

int cake_w = int.Parse(Console.ReadLine());
int cake_h = int.Parse(Console.ReadLine());

int total_cake = cake_w * cake_h;
bool isfinished = false;


while (total_cake >= 0)
{
    string command = Console.ReadLine();
    if (command == "STOP")
    {
        break;
    }
    total_cake -= int.Parse(command);

}


if (total_cake >= 0)
{
    Console.WriteLine($"{total_cake} pieces are left.");
}
else
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(total_cake)} pieces more.");
}
