using System;

class Program
{
    static void Main()
    {
        // Reading input values
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());

        // Save the original value of N
        int originalN = N;

        // Count of targets poked
        int count = 0;

        // Subtract M from N until N becomes less than M
        while (N >= M)
        {
            N -= M;
            count++;

            // Check if N is exactly 50% of its original value
            if (N == 0.5 * originalN)
            {
                // Check if division by Y is possible
                if (Y != 0)
                {
                    N /= Y;
                }
            }
        }

        // Print the remaining N and the count of targets poked
        Console.WriteLine(N);
        Console.WriteLine(count);
    }
}
