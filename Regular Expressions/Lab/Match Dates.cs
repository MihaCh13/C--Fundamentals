using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        var pattern = @"((?<day>\d{2})[/](?<month>[A-Z][a-z]{2})[/](?<year>[0-9]{4}))|((?<day>\d{2})[-](?<month>[A-Z][a-z]{2})[-](?<year>[0-9]{4}))|((?<day>\d{2})[.](?<month>[A-Z][a-z]{2})[.](?<year>[0-9]{4}))";
        var dates = Console.ReadLine();
        var matches = Regex.Matches(dates, pattern);

        foreach (Match date in matches)
        {
            var day = date.Groups["day"].Value;
            var month = date.Groups["month"].Value;
            var year = date.Groups["year"].Value;
            Console.WriteLine($"Day: {day}, Month: { month}, Year: { year}");
        }
    }
}
