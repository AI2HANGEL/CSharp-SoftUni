int n = int.Parse(Console.ReadLine());

Dictionary<string, string> parkingDatabase = new Dictionary<string, string>();

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split();

    if (command[0] == "register")
    {
        string username = command[1];
        string licensePlateNumber = command[2];

        if (parkingDatabase.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number {parkingDatabase[username]}");
        }
        else
        {
            parkingDatabase[username] = licensePlateNumber;
            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
        }
    }
    else if (command[0] == "unregister")
    {
        string username = command[1];

        if (parkingDatabase.ContainsKey(username))
        {
            parkingDatabase.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
    }
}

foreach (var pair in parkingDatabase)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}