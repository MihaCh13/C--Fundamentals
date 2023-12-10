using System;

class Program
{
    static void Main(string[] args)
    {
        string firstLine = Console.ReadLine();
        string secondLine = Console.ReadLine();

        string result = MultiplyLargeNumbers(firstLine, secondLine);
        Console.WriteLine(result);
    }

    static string MultiplyLargeNumbers(string num1, string num2)
    {
        int len1 = num1.Length;
        int len2 = num2.Length;
        int[] result = new int[len1 + len2];

        for (int i = len1 - 1; i >= 0; i--)
        {
            for (int j = len2 - 1; j >= 0; j--)
            {
                int product = (num1[i] - '0') * (num2[j] - '0');
                int sum = product + result[i + j + 1];

                result[i + j] += sum / 10;
                result[i + j + 1] = sum % 10;
            }
        }

        string multiplicationResult = string.Join("", result).TrimStart('0');
        return string.IsNullOrEmpty(multiplicationResult) ? "0" : multiplicationResult;
    }
}

// Concat() --> + string.Concat("a" + "b") --> "ab"
// IndexOf() --> "text".IndexOf(t, 1) --> 3
// LastIndexOf() --> "text". LastIndexOf(t,1) --> 0
// Contains(); --> true/false name.Contains("ana", StringComparison.InvariantCultureIgnoreCase)
// Substring() --> "Anastasia". Substring(0, 3); -- "Ana"
// Split() --> .Split(new char[] { ',', '.', '' }, StringSplitOptions.RemoveEmptyEntries)
// Remove() --> remove part of string
// Reverse() --> reverse string
// Trim() --> remove whitespaces from end, start...
// ToLower() -> FILIP -> filip
// Replace --> replace all
