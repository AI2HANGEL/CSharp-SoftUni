using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"(?<day>\d{2})(?<separator>[\.|\/|\-])(?<month>[A-z][a-z]+)\2(?<year>\d{4})";
Regex re = new Regex(pattern);

MatchCollection match = re.Matches(input);

foreach (Match element in match)
{
    Console.WriteLine($"Day: {element.Groups["day"]}, " +
        $"Month: {element.Groups["month"]}, " +
        $"Year: {element.Groups["year"]}");
} 

