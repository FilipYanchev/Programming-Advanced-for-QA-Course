using System.Text.RegularExpressions;

string pattern = @"\b(?<day>\d{2})(?<sep>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<sep>(?<year>\d{4})\b";
Regex regex = new Regex(pattern);

string input = Console.ReadLine();

MatchCollection mathes = regex.Matches(input);

foreach (Match match in mathes)
{
    Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
}
