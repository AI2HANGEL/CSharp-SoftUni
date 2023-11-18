using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"\b[A-Z][a-z]+ \b[A-Z][a-z]+";
Regex re = new Regex(pattern);

MatchCollection match = re.Matches(input);

Console.WriteLine(string.Join(" ", match));