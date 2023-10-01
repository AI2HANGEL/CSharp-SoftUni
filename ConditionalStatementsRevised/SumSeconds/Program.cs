int timeSecondsA = int.Parse(Console.ReadLine());
int timeSecondsB = int.Parse(Console.ReadLine());
int timeSecondsC = int.Parse(Console.ReadLine());


int minutes = (timeSecondsA + timeSecondsB + timeSecondsC) / 60;
int seconds = (timeSecondsA + timeSecondsB + timeSecondsC) % 60;

string formattedMinutes = minutes.ToString().PadLeft(1, '0');
string formattedSeconds = seconds.ToString().PadLeft(2, '0');

Console.WriteLine($"{formattedMinutes}:{formattedSeconds}");