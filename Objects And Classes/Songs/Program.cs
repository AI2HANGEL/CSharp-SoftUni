int numberOfSongs = int.Parse(Console.ReadLine());
List<Song> songs = new List<Song>();

for (int i = 0; i < numberOfSongs; i++)
{
    string[] songElements = Console.ReadLine().Split("_");
    string songType = songElements[0];
    string songName = songElements[1];
    string songTime = songElements[2];

    Song current = new Song
    {
        Name = songName,
        TypeList = songType,
        Time = songTime,
    };
    songs.Add(current);
}

string command = Console.ReadLine();

if (command == "all")
{
    foreach (Song song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    List<Song> filtered = songs.Where(x => x.TypeList == command).ToList();
    foreach (Song song in filtered)
    {
        Console.WriteLine(song.Name);
    }
}


public class Song
{
    public string TypeList{ get; set; }

    public string Name { get; set; }

    public string Time { get; set; }
}