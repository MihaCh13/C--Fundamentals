using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> sequence = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        int removedElementsSum = PlayPokemonDontGo(sequence);
        Console.WriteLine(removedElementsSum);
    }

    static int PlayPokemonDontGo(List<int> sequence)
    {
        int removedElementsSum = 0;

        while (sequence.Count > 0)
        {
            string[] indexes = Console.ReadLine().Split();
            
            if (indexes.Length == 0)
                break;

            int index = int.Parse(indexes[0]);

            if (index >= 0 && index < sequence.Count)
            {
                int removedElement = sequence[index];
                sequence.RemoveAt(index);
                removedElementsSum += removedElement;

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= removedElement)
                        sequence[i] += removedElement;
                    else
                        sequence[i] -= removedElement;
                }
            }
            else if (index < 0)
            {
                int removedElement = sequence[0];
                sequence.RemoveAt(0);
                sequence.Insert(0, sequence[sequence.Count - 1]);
                removedElementsSum += removedElement;

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= removedElement)
                        sequence[i] += removedElement;
                    else
                        sequence[i] -= removedElement;
                }
            }
            else if (index >= sequence.Count)
            {
                int removedElement = sequence[sequence.Count - 1];
                sequence.RemoveAt(sequence.Count - 1);
                sequence.Add(sequence[0]);
                removedElementsSum += removedElement;

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= removedElement)
                        sequence[i] += removedElement;
                    else
                        sequence[i] -= removedElement;
                }
            }
        }

        return removedElementsSum;
    }
}
