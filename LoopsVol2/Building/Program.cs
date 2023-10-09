int floors = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());

char floorLetter = ' ';

for (int currentFloor = floors; currentFloor > 0; currentFloor--)
{
    for (int currentRoom = 0; currentRoom < rooms; currentRoom++)
    {
        if (currentFloor == floors)
        {
            floorLetter = 'L';
        }
        else if (currentFloor % 2 == 0)
        {
            floorLetter = 'O';
        }
        else
        {
            floorLetter = 'A';
        }

        Console.Write($"{floorLetter}{currentFloor}{currentRoom} ");
    }
    Console.WriteLine();
}
