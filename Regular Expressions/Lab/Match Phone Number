using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var pattern = @"(?<num>((\+359)( )(2)( )([0-9]{3})( )([0-9]{4}))|(\+359)(-)(2)(-)([0-9]{3})(-)([0-9]{4})\b)";
        var numbers = Console.ReadLine();
        var matches = Regex.Matches(numbers, pattern);
        var matchedPhones = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
        Console.WriteLine(string.Join(", ", matchedPhones));
    }
}
