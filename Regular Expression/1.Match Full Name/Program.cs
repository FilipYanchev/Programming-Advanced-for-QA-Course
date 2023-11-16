using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
Regex regex = new Regex(pattern);

string input = Console.ReadLine();

MatchCollection mathes = regex.Matches(input);

Console.WriteLine(string.Join(" ", mathes));
