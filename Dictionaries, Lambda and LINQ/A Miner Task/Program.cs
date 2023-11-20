Dictionary<string, long> resources = new Dictionary<string, long>();

while (true)
{
    string resource = Console.ReadLine();

    if (resource == "stop")
    {
        break;
    }

    long quantity = long.Parse(Console.ReadLine());

    if (resources.ContainsKey(resource))
    {
        resources[resource] += quantity;
    }
    else
    {
        resources.Add(resource, quantity);
    }
}

foreach (KeyValuePair<string, long> pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
