namespace AnonymousThreat
{
	internal class Program
	{
		static void Main()
		{
			List<string> input = Console.ReadLine().
				Split(' ').
				ToList();

			string command;
			while ((command = Console.ReadLine()) != "3:1")
			{
				string[] tokens = command.Split();
				switch (tokens[0])
				{
					case "merge":
						int startIndex = int.Parse(tokens[1]);
						int endIndex = int.Parse(tokens[2]);
						input = MergeElements(startIndex, endIndex, input);
						break;
					case "divide":
						int index = int.Parse(tokens[1]);
						int partitions = int.Parse(tokens[2]);
						input = Divide(input, index, partitions);
						break;
				}
			}
			Console.WriteLine(string.Join(' ', input));
		}

		static List<string> MergeElements(int startIndex, int endIndex, List<string> input)
		{
			startIndex = SetIndexInRange(startIndex, input.Count - 1);
			endIndex = SetIndexInRange(endIndex, input.Count - 1);
			string mergedPart = "";
			for (int i = startIndex; i <= endIndex; i++)
			{
				mergedPart += input[i];
			}
			input.RemoveRange(startIndex, endIndex - startIndex + 1);
			input.Insert(startIndex, mergedPart);
			return input;
		}
		static List<string> Divide(List<string> input, int index, int partitions)
		{
			string parts = GetDividedSubstring(input, partitions, index);
			input.RemoveAt(index);
			if (parts == " ")
			{
				return input;
			}

			List<string> partsList = parts.Split(' ').ToList();
			for (int i = partsList.Count - 1; i >= 0; i--)
			{
				input.Insert(index, partsList[i]);
			}
			return input;
		}
		static string GetDividedSubstring(List<string> input, int partitions, int index)
		{
			if (partitions <= 0)
			{
				return " ";
			}
			string parts = "";
			int lenghtEqualParts = input[index].Length / partitions;
			int longestPart = input[index].Length % partitions;
			int indexString = 0;
			for (int i = 0; i < partitions; i++)
			{
				for (int j = 0; j < lenghtEqualParts; j++)
				{
					parts += input[index][indexString];
					indexString++;
				}
				parts += " ";
			}
			parts = parts.TrimEnd(' ');
			if (longestPart > 0)
			{
				for (int i = indexString; i < input[index].Length; i++)
				{
					parts += input[index][i];
				}
			}
			return parts;

		}
		static int SetIndexInRange(int index, int listRange)
		{
			if (index < 0)
			{
				index = 0;
			}
			else if (index > listRange)
			{
				index = listRange;
			}
			return index;
		}
	}

}
