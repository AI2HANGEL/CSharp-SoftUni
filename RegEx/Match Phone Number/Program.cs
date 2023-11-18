using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"\+359([\ \-])2\1([\d]{3})\1([\d]{4})\b";
Regex re = new Regex(pattern);

MatchCollection match = re.Matches(input);

Console.WriteLine(string.Join(", ", match));